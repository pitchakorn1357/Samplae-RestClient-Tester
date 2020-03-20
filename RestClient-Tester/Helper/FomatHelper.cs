using RestClient_Tester.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient_Tester.Helper
{
    public static class FomatHelper
    {
        public static string FormatJsonOutput(string jsonString)
        {
            var stringBuilder = new StringBuilder();

            bool escaping = false;
            bool inQuotes = false;
            int indentation = 0;

            foreach (char character in jsonString)
            {
                if (escaping)
                {
                    escaping = false;
                    stringBuilder.Append(character);
                }
                else
                {
                    if (character == '\\')
                    {
                        escaping = true;
                        stringBuilder.Append(character);
                    }
                    else if (character == '\"')
                    {
                        inQuotes = !inQuotes;
                        stringBuilder.Append(character);
                    }
                    else if (!inQuotes)
                    {
                        if (character == ',')
                        {
                            stringBuilder.Append(character);
                            stringBuilder.Append("\r\n");
                            stringBuilder.Append('\t', indentation);
                        }
                        else if (character == '[' || character == '{')
                        {
                            stringBuilder.Append(character);
                            stringBuilder.Append("\r\n");
                            stringBuilder.Append('\t', ++indentation);
                        }
                        else if (character == ']' || character == '}')
                        {
                            stringBuilder.Append("\r\n");
                            stringBuilder.Append('\t', --indentation);
                            stringBuilder.Append(character);
                        }
                        else if (character == ':')
                        {
                            stringBuilder.Append(character);
                            stringBuilder.Append(' ');
                        }
                        else if (!Char.IsWhiteSpace(character))
                        {
                            stringBuilder.Append(character);
                        }
                    }
                    else
                    {
                        stringBuilder.Append(character);
                    }
                }
            }

            return stringBuilder.ToString();
        }
        public static string FormatTextOutput(string textString)
        {
            string response = "";

            response = textString.Replace("\"", string.Empty);
            response = response.Replace("\\r\\n", Environment.NewLine);
            response = response.Replace("\r\n", Environment.NewLine);

            return response;
        }
        public static string checkRequestBody(string body)
        {
            string response = "";
            if (body != null && body != "")
            {
                response = body.Replace("\\r\\n", string.Empty);
                response = response.Replace("\r\n", string.Empty);
                response = response.Replace("\t", string.Empty);
                response = response.Replace(" ", string.Empty);
                
            }
            if (response == "") response = "{}";
            return response;
        }
        public static List<RequestHeaderModel> ParseTextToHeader(string testString)
        {
            List<RequestHeaderModel> response = new List<RequestHeaderModel>();

            testString.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList().ForEach(line =>
            {
                if (line.Trim() != "" && line.Trim() != null)
                {
                    if (line.Trim()[0] != '#')
                    {
                        line = line.Replace(" ", string.Empty);

                        var SplitLine = line.Split(new[] { "\":\"" }, StringSplitOptions.None);

                        string headerKey = SplitLine[0].Replace("\"", string.Empty);
                        string headerValue = SplitLine[1].Replace("\"", string.Empty);

                        response.Add(new RequestHeaderModel()
                        {
                            HeaderKey = headerKey,
                            HeaderValue = headerValue
                        });
                    }
                }
            });
            return response;
        }
    }
}
