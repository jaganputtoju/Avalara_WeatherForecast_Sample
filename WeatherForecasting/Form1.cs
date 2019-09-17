using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeatherForecasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetWeatherForeacst_Click(object sender, EventArgs e)
        {

            try
            {
                DataSet dsData = new DataSet();
                //Get selected date to get weather data for that date
                DateTime selectedDate = Convert.ToDateTime(dtForecastDay.Text);
                lblWeatherDay.Text = "Weather For Day ";
                lblWeatherDay.Text += selectedDate.ToShortDateString();

                string month = selectedDate.ToString("MMMMMMMMMMM");
                string day = selectedDate.Day.ToString();
                //Make a select command by using month  and day from selected date 
                string command = "Select * from [Sheet1$] where [Day of Month] = @Day and [Month] = @Month";
                //Bekiw connection stirng is to fetch date from input data source. Input file needs to be there at below location.
                string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\jputtoj\\source\\repos\\WeatherForecasting\\WeatherForecasting\\DataSource\\weather-data.xlsx;Extended Properties='Excel 8.0;HDR=YES;'";

                //Below Using statment make sure connection object properly closed and all other resources including connection object are disposed properly
                using (OleDbConnection connection = new OleDbConnection(connString))
                {
                    connection.Open();
                    //Use command object to initialize command and set query paramters
                    OleDbCommand cmd = new OleDbCommand(command);
                    cmd.Parameters.Add(new OleDbParameter("@Day", day));
                    cmd.Parameters.Add(new OleDbParameter("@Month", month));
                    cmd.Connection = connection;
                    OleDbDataAdapter adaptor = new OleDbDataAdapter(cmd);
                    //Now try to execute the command and get the date to a dataset
                    adaptor.Fill(dsData);

                    string jsonWeatherData = string.Empty;
                    //Check if one table and one row returned for the selected date
                    if (dsData.Tables.Count > 0 && dsData.Tables[0].Rows.Count > 0)
                        //Convert found matching date to JSON string
                        jsonWeatherData = JsonConvert.SerializeObject(dsData.Tables[0]);
                    else
                        MessageBox.Show("Some unknown error occured or there is some issue in retrieving the weather data. Please call Avalara Weather Forecasting help desk team");

                    //Show above JSON string in rich text box to the user
                    richTextWaetherResult.Text = jsonWeatherData;
                }
            }
            catch(Exception ex)
            {
                //Display any exceptions or errors to the user
                MessageBox.Show("Some unknown error occured or there is some issue in retrieving the weather data. Please call Avalara Weather Forecasting help desk team");
            }
            
        }
    }
}
