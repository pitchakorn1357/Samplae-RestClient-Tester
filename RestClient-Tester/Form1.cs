using RestClient_Tester.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using RestClient_Tester.Helper;
using System.Reflection;
using System.Diagnostics;
using System.IO;

namespace RestClient_Tester
{
    public partial class Form1 : Form
    {
        private List<RequestHistoryModel> ListRequestHistory = new List<RequestHistoryModel>();
        List<DropDownUrlModel> dropDownUrl = new List<DropDownUrlModel>();

        public Form1()
        {
            InitializeComponent();

            SetDropDownMethod();

            // Example Request Headers
            textBoxRequestHeader.Text = "# Example add custom request header" + Environment.NewLine
                                      + "# Use Comment press '#' begin line" + Environment.NewLine
                                      + "# \"X-Application-Name\" : \"TEST-SYSTEM\"" + Environment.NewLine
                                      + "# \"X-APIKEY\" : \"AUp3x6Uqiesw61LP6qERieUdeTkRstGXflNh/KHxAD8=\"";
        }
        private void SetDropDownMethod()
        {
            comboBoxMethod.SelectedIndex = 0;

            comboBoxUrl.DisplayMember = "Text";
            comboBoxUrl.ValueMember = "Value";
        }
        
        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            RequestHistoryModel requestHistoryModel = new RequestHistoryModel()
            {
                Method = comboBoxMethod.Text,
                Url = comboBoxUrl.Text,
                Body = textBoxRequestBody.Text,
                Header = textBoxRequestHeader.Text,
                CreateDate = DateTime.Now
            };
            ListRequestHistory.Insert(0, requestHistoryModel);


            dropDownUrl.Insert(0, new DropDownUrlModel(){
                Text = requestHistoryModel.Url,
                Value = requestHistoryModel.CreateDate
            });
            comboBoxUrl.DataSource = new BindingSource(dropDownUrl, null);

            List<RequestHeaderModel> listHeader = FomatHelper.ParseTextToHeader(requestHistoryModel.Header);

            SubmitRequest(comboBoxMethod.Text, comboBoxUrl.Text, textBoxRequestBody.Text, listHeader);
        }

        private void SubmitRequest(string method, string Url, string Body, List<RequestHeaderModel> listHeader)
        {
            textBoxResponseHeader.Text = "Loading...";
            textBoxResponseBody.Text = "Loading...";
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Encoding = Encoding.UTF8;
                    client.UseDefaultCredentials = true;
                    client.BaseAddress = Url;
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    listHeader.ForEach(header =>
                    {
                        client.Headers.Add(header.HeaderKey, header.HeaderValue);
                    });

                    var response = client.UploadString(
                            new Uri(Url),
                            method,
                            FomatHelper.checkRequestBody(Body)
                        );

                    textBoxResponseHeader.Text = "";
                    textBoxResponseBody.Text = "";

                    FieldInfo responseField = client.GetType().GetField("m_WebResponse", BindingFlags.Instance | BindingFlags.NonPublic);
                    if (responseField != null)
                    {
                        HttpWebResponse resp = responseField.GetValue(client) as HttpWebResponse;

                        if (resp != null)
                        {
                            var statusDescription = resp.StatusDescription;
                            textBoxResponseHeader.AppendText("Server : " + resp.Server + Environment.NewLine);
                            textBoxResponseHeader.AppendText("Server Status : " + resp.StatusDescription + Environment.NewLine);
                            textBoxResponseHeader.AppendText("Uri : " + resp.ResponseUri.ToString() + Environment.NewLine);
                            textBoxResponseHeader.AppendText("Protocol Version : " + resp.ProtocolVersion + Environment.NewLine);
                            textBoxResponseHeader.AppendText("Supports Headers : " + resp.SupportsHeaders + Environment.NewLine + Environment.NewLine);
                            textBoxResponseHeader.AppendText("Status Code : " + resp.StatusCode + Environment.NewLine);
                            textBoxResponseHeader.AppendText("Status Description : " + resp.StatusDescription + Environment.NewLine + Environment.NewLine);
                        }
                    }

                    textBoxResponseHeader.Text += client.ResponseHeaders.ToString();

                    try
                    {
                        var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(response);
                        var responseJson = new JavaScriptSerializer().Serialize(dict);

                        textBoxResponseBody.Text = FomatHelper.FormatJsonOutput(response);
                    }
                    catch (Exception ex)
                    {
                        textBoxResponseBody.Text = FomatHelper.FormatTextOutput(response);
                    }
                }
                catch (Exception ex)
                {
                    textBoxResponseBody.Text = ex.Message;
                    textBoxResponseHeader.Text = "";
                }
            }
        }

        private void comboBoxUrl_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxUrl.SelectedItem != null)
            {
                DateTime urlCreatedate = (comboBoxUrl.SelectedItem as dynamic).Value;
                var History = ListRequestHistory.Where(x => x.Method == comboBoxMethod.Text && x.Url == comboBoxUrl.Text && x.CreateDate == urlCreatedate).FirstOrDefault();
                if (History != null)
                {
                    textBoxRequestBody.Text = History.Body;
                    textBoxRequestHeader.Text = History.Header;
                }
            }
        }

        private void textBoxRequestBody_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxRequestBody_KeyDown(object sender, KeyEventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Restclient-Tester";

            if (!System.IO.Directory.Exists(userPath))
                System.IO.Directory.CreateDirectory(userPath);

            System.IO.File.WriteAllText(userPath + "\\TempResponse.txt", textBoxResponseBody.Text);
            Process.Start(userPath + "\\TempResponse.txt");
        }
    }
}
