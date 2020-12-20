using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.FileIO;

namespace Veritas_RRD
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Where the file is gonna save.
            //string saveFolder = ConfigurationManager.AppSettings["localCSV"];
            //Filepath
            string filePath = Path.Combine(@"C:\", FileUpload1.FileName);
            int count = 0;
            int count2 = 0;
            //Datatable to save the csv
            DataTable dt = new DataTable();
            //Datatable to create the new csv with the new structure
            DataTable dtNew = new DataTable();
            DataTable dtNew2 = new DataTable();
            // Save the file in a local space to handle.
            FileUpload1.SaveAs(filePath);
            //read CSV
            StreamReader reader = new StreamReader(File.OpenRead(filePath));
            List<string> listA = new List<String>();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');
                    if (values.Length >= 25)
                    {
                        foreach (var item in values)
                        {
                            if (count == 0)
                            {
                                DataColumn col = new DataColumn(item);
                                dt.Columns.Add(col);
                            }                           

                            if (count > 0)
                            {
                                DataRow dr = dt.NewRow();
                                for (int i = 0; i < values.Length; i++)
                                {
                                        dr[i] = values[i];
                                }
                                dt.Rows.Add(dr);
                                break;
                            }
                        }
                            count += 1;
                        }
                  
                }
            }
            //Create new structure of new csv
            DataColumn colNew = new DataColumn("Flag1", typeof(string));
            dtNew.Columns.Add(colNew);
            DataColumn colNew1 = new DataColumn("Flag2", typeof(string));
            dtNew.Columns.Add(colNew1);
            DataColumn colNew2 = new DataColumn("Flag3", typeof(string));
            dtNew.Columns.Add(colNew2);
            DataColumn colNew3 = new DataColumn("Flag4", typeof(string));
            dtNew.Columns.Add(colNew3);
            DataColumn colNew4 = new DataColumn("Flag5", typeof(string));
            dtNew.Columns.Add(colNew4);
            DataColumn colNew5 = new DataColumn("Name", typeof(string));
            dtNew.Columns.Add(colNew5);
            DataColumn colNew6 = new DataColumn("Address", typeof(string));
            dtNew.Columns.Add(colNew6);
            DataColumn colNew7 = new DataColumn("City", typeof(string));
            dtNew.Columns.Add(colNew7);
            DataColumn colNew8 = new DataColumn("State", typeof(string));
            dtNew.Columns.Add(colNew8);
            DataColumn colNew9 = new DataColumn("Zip", typeof(string));
            dtNew.Columns.Add(colNew9);
            //Review the old csv to create the new csv
            foreach (DataRow itemrow in dt.Rows)
            {
                
                DataRow drNew = dtNew.NewRow();
                for (int i = 0; i <= 24; i++)
                {
                    if (i <= 4)
                    {
                        //The first time create the estructure of flags
                        drNew[i] = itemrow[i];
                    }
                    if (dt.Columns[i].ColumnName == "Name1" && itemrow[i].ToString() != "")
                    {
                        int j = 0;
                        int h = i;
                        drNew[i] = itemrow[i];
                        j = i + 4;
                        h = h + 1;
                        drNew[h] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew[h] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew[h] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew[h] = itemrow[j];
                        dtNew.Rows.Add(drNew);
                    }
                    if (dt.Columns[i].ColumnName == "Name2" && itemrow[i].ToString() != "")
                    {
                        //when find the column name, create the structure in a new line.
                        DataRow drNew2 = dtNew.NewRow();
                        //drNew2[i] = itemrow[i];
                        int j = 0;
                        int h = 0;
                        int f = 6;
                        drNew2[0] = drNew[0];
                        drNew2[1] = drNew[1];
                        drNew2[2] = drNew[2];
                        drNew2[3] = drNew[3];
                        drNew2[4] = drNew[4];

                        drNew2[5] = itemrow[f];
                        j = f + 4;
                        h = h + 1;
                        drNew2[6] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew2[7] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew2[8] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew2[9] = itemrow[j];
                        dtNew.Rows.Add(drNew2);
                    }
                    if (dt.Columns[i].ColumnName == "Name3" && itemrow[i].ToString() != "")
                    {
                        //when find the column name, create the structure in a new line.
                        DataRow drNew3 = dtNew.NewRow();
                        //drNew2[i] = itemrow[i];
                        int j = 0;
                        int h = 0;
                        int f = 7;
                        drNew3[0] = drNew[0];
                        drNew3[1] = drNew[1];
                        drNew3[2] = drNew[2];
                        drNew3[3] = drNew[3];
                        drNew3[4] = drNew[4];

                        drNew3[5] = itemrow[f];
                        j = f + 4;
                        h = h + 1;
                        drNew3[6] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew3[7] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew3[8] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew3[9] = itemrow[j];
                        dtNew.Rows.Add(drNew3);
                    }
                    if (dt.Columns[i].ColumnName == "Name4" && itemrow[i].ToString() != "")
                    {
                        //when find the column name, create the structure in a new line.
                        DataRow drNew4 = dtNew.NewRow();
                        //drNew2[i] = itemrow[i];
                        int j = 0;
                        int h = 0;
                        int f = 8;
                        drNew4[0] = drNew[0];
                        drNew4[1] = drNew[1];
                        drNew4[2] = drNew[2];
                        drNew4[3] = drNew[3];
                        drNew4[4] = drNew[4];

                        drNew4[5] = itemrow[f];
                        j = f + 4;
                        h = h + 1;
                        drNew4[6] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew4[7] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew4[8] = itemrow[j];
                        j += 4;
                        h = h + 1;
                        drNew4[9] = itemrow[j];
                        dtNew.Rows.Add(drNew4);
                    }
                }
               
                count2 += 1;
            }
            //Create the new CSV FILE, it´s create in DISK "C"
            CreateCSVFile(dtNew);
        }

        static private void CreateCSVFile(DataTable dt)
        {

            //checked for the datatable dtCSV not empty
            if (dt != null && dt.Rows.Count > 0)
            {
                // create object for the StringBuilder class
                StringBuilder sb = new StringBuilder();

                // Get name of columns from datatable and assigned to the string array
                string[] columnNames = dt.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();

                // Create comma sprated column name based on the items contains string array columnNames
                sb.AppendLine(string.Join(",", columnNames));

                // Fatch rows from datatable and append values as comma saprated to the object of StringBuilder class 
                foreach (DataRow row in dt.Rows)
                {
                    IEnumerable<string> fields = row.ItemArray.Select(field => string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                    sb.AppendLine(string.Join(",", fields));
                }

                // save the file
                File.WriteAllText(@"C:\MOCK_DATA_NEW.csv", sb.ToString());
            }
        }
    }
}