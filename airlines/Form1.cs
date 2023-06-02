using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airlines
{
    public partial class FormRoutes : Form
    {
        public FormRoutes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ConnectionStr = "Data Source=127.0.0.1;Port=3306;User ID=root;Password=Aa123456;database=mysql";
            MySqlConnection connection = new MySqlConnection(ConnectionStr);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("CREATE SCHEMA `airline`",connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            string newConnectionStr= "Data Source=127.0.0.1;Port=3306;User ID=root;Password=Aa123456;database=airline";
            MySqlConnection newconnection = new MySqlConnection(newConnectionStr);
            newconnection.Open();
            MySqlCommand newcmd = new MySqlCommand("CREATE TABLE `airline`.`typesofplanes` (\r\n  `id` INT NOT NULL AUTO_INCREMENT,\r\n  `type` VARCHAR(45) NOT NULL,\r\n  PRIMARY KEY (`id`))",newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("CREATE TABLE `airline`.`routes` (\r\n  `id` INT NOT NULL AUTO_INCREMENT,\r\n  `number` VARCHAR(45) NOT NULL,\r\n  `departAndLand` VARCHAR(45) NOT NULL,\r\n  PRIMARY KEY (`id`))", newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("CREATE TABLE `airline`.`timetable` (\r\n  `id` INT NOT NULL AUTO_INCREMENT,\r\n  `planeId` INT NOT NULL,\r\n  `routeId` INT NOT NULL,\r\n  `timeOfDepart` VARCHAR(45) NOT NULL DEFAULT '00:00',\r\n  PRIMARY KEY (`id`));",newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("ALTER TABLE `airline`.`timetable` \r\nADD CONSTRAINT `typeofplanes_timetable`\r\n  FOREIGN KEY (`planeId`)\r\n  REFERENCES `airline`.`typesofplanes` (`id`)\r\n  ON DELETE NO ACTION\r\n  ON UPDATE NO ACTION", newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("ALTER TABLE `airline`.`timetable` \r\nADD CONSTRAINT `routes_timetable`\r\n  FOREIGN KEY (`routeId`)\r\n  REFERENCES `airline`.`routes` (`id`)\r\n  ON DELETE NO ACTION\r\n  ON UPDATE NO ACTION", newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("INSERT INTO `airline`.`typesofplanes` (`type`) VALUES ('b737-800')",newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("INSERT INTO `airline`.`typesofplanes` (`type`) VALUES ('a350-1000')", newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("INSERT INTO `airline`.`typesofplanes` (`type`) VALUES ('ssj-100')", newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("INSERT INTO `airline`.`typesofplanes` (`type`) VALUES ('tu154')", newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("INSERT INTO `airline`.`typesofplanes` (`type`) VALUES ('il96')", newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("INSERT INTO `airline`.`routes` (`number`,`departAndLand`) VALUES ('su1043','Владикавказ-Москва')", newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("INSERT INTO `airline`.`routes` (`number`,`departAndLand`) VALUES ('a4858','Минеральные Воды-Самара')", newconnection);
            newcmd.ExecuteNonQuery();
            newcmd = new MySqlCommand("INSERT INTO `airline`.`routes` (`number`,`departAndLand`) VALUES ('fv162','Санкт-Петербург-Магадан')", newconnection);
            newcmd.ExecuteNonQuery();
            newconnection.Close();
            string connect = "Data Source=127.0.0.1;Port=3306;User ID=root;Password=Aa123456;database=airline";
            connection = new MySqlConnection(connect);
            connection.Open();
            string sql = "select * from airline.typesofplanes";
            MySqlCommand mySqlCommand2 = new MySqlCommand(sql, connection);
            MySqlDataReader res2 = mySqlCommand2.ExecuteReader(); //отвечает за считывание
            listBoxTypesofPlanes.Items.Add(String.Format("{0}\t{1}", res2.GetName(0), res2.GetName(1))); //имена столбцов
            while (res2.Read()) //пока мы можем что-то считать получилось-не получилось
            {
                object id = res2.GetValue(0);
                object title = res2.GetValue(1);
                comboBoxPlane.Items.Add(title.ToString());
                comboBoxRPlane.Items.Add(title.ToString());
                listBoxTypesofPlanes.Items.Add(String.Format("{0}\t{1}", id, title));
            }
            res2.Close();
            string sql2 = "select * from airline.routes";
            MySqlCommand mySqlCommand3 = new MySqlCommand(sql2, connection);
            MySqlDataReader res3 = mySqlCommand3.ExecuteReader(); //отвечает за считывание
            listBoxroutes.Items.Add(String.Format("{0}\t{1}\t{2}", res3.GetName(0), res3.GetName(1), res3.GetName(2))); //имена столбцов
            while (res3.Read()) //пока мы можем что-то считать получилось-не получилось
            {
                object id = res3.GetValue(0);
                object title = res3.GetValue(1);
                object route = res3.GetValue(2);
                comboBoxRoute.Items.Add(route.ToString());
                comboBoxRRoute.Items.Add(route.ToString());
                listBoxroutes.Items.Add(String.Format("{0}\t{1}\t{2}", id, title, route));
            }
        }

        

        private void buttonCreateRoute_Click(object sender, EventArgs e)
        {
            comboBoxIds.Items.Clear();
            listBoxtable.Items.Clear();
            string connect = "Data Source=127.0.0.1;Port=3306;User ID=root;Password=Aa123456;database=airline";
            MySqlConnection connection = new MySqlConnection(connect);
            connection.Open();
            string plane=comboBoxPlane.SelectedItem.ToString();
            string route=comboBoxRoute.SelectedItem.ToString(); 
            string time=textBoxDeparture.Text;
            char r = '"';
            MySqlCommand first=new MySqlCommand($"select id from airline.typesofplanes where type={r}{plane}{r}", connection);
            MySqlCommand second = new MySqlCommand($"select id from airline.routes where departAndLand={r}{route}{r}", connection);
            var planeid = first.ExecuteScalar();
            var routeid = second.ExecuteScalar();
            MySqlCommand final = new MySqlCommand($"insert into airline.timetable(planeId,routeId,timeofDepart) values({r}{planeid}{r},{r}{routeid}{r},{r}{time}{r})",connection);
            final.ExecuteNonQuery();
            string sql = "select * from airline.timetable";
            MySqlCommand mySqlCommand2 = new MySqlCommand(sql, connection);
            MySqlDataReader res2 = mySqlCommand2.ExecuteReader(); //отвечает за считывание
            listBoxtable.Items.Add(String.Format("{0}\t{1}\t{2}\t{3}", res2.GetName(0), res2.GetName(1), res2.GetName(2), res2.GetName(3))); //имена столбцов
            while (res2.Read()) //пока мы можем что-то считать получилось-не получилось
            {
                object id = res2.GetValue(0);
                object nplaneid = res2.GetValue(1);
                object nrouteid = res2.GetValue(2);
                object t=res2.GetValue(3);
                listBoxtable.Items.Add(String.Format("{0}\t{1}\t{2}\t{3}", id, nplaneid,nrouteid,t));
            }
            res2.Close();
            MySqlCommand idcom = new MySqlCommand("select id from airline.timetable", connection);
            res2 = idcom.ExecuteReader();
            while(res2.Read())
            {
                object id=res2.GetValue(0);
                comboBoxIds.Items.Add(id);
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxtable.Items.Clear();
            int id = Convert.ToInt32(comboBoxIds.SelectedItem);
            string connect = "Data Source=127.0.0.1;Port=3306;User ID=root;Password=Aa123456;database=airline";
            MySqlConnection connection = new MySqlConnection(connect);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand($"delete from airline.timetable where id={id}", connection);
            cmd.ExecuteNonQuery();
            string sql = "select * from airline.timetable";
            MySqlCommand mySqlCommand2 = new MySqlCommand(sql, connection);
            MySqlDataReader res2 = mySqlCommand2.ExecuteReader(); //отвечает за считывание
            listBoxtable.Items.Add(String.Format("{0}\t{1}\t{2}\t{3}", res2.GetName(0), res2.GetName(1), res2.GetName(2), res2.GetName(3))); //имена столбцов
            while (res2.Read()) //пока мы можем что-то считать получилось-не получилось
            {
                object i = res2.GetValue(0);
                object nplaneid = res2.GetValue(1);
                object nrouteid = res2.GetValue(2);
                object t = res2.GetValue(3);
                listBoxtable.Items.Add(String.Format("{0}\t{1}\t{2}\t{3}", i, nplaneid, nrouteid, t));
            }
            res2.Close();
            connection.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            listBoxtable.Items.Clear();
            int id = Convert.ToInt32(comboBoxIds.SelectedItem);
            string connect = "Data Source=127.0.0.1;Port=3306;User ID=root;Password=Aa123456;database=airline";
            MySqlConnection connection = new MySqlConnection(connect);
            connection.Open();
            string plane = comboBoxRPlane.SelectedItem.ToString();
            string route = comboBoxRRoute.SelectedItem.ToString();
            string time=textBoxRData.Text;
            char r = '"';
            MySqlCommand mySqlCommand = new MySqlCommand($"select id from airline.typesofplanes where type={r}{plane}{r}",connection);
            MySqlCommand mySqlSCommand = new MySqlCommand($"select id from airline.routes where departAndLand={r}{route}{r}", connection);
            var first = mySqlCommand.ExecuteScalar();
            var second= mySqlSCommand.ExecuteScalar();
            MySqlCommand cmd = new MySqlCommand($"update airline.timetable set planeId={first}where id={id}",connection);
            MySqlCommand cmd2 = new MySqlCommand($"update airline.timetable set routeId={second}where id={id}", connection);
            MySqlCommand final = new MySqlCommand($"update airline.timetable set timeOfDepart={time}where id={id}", connection);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            final.ExecuteNonQuery();
            string sql = "select * from airline.timetable";
            MySqlCommand mySqlCommand2 = new MySqlCommand(sql, connection);
            MySqlDataReader res2 = mySqlCommand2.ExecuteReader(); //отвечает за считывание
            listBoxtable.Items.Add(String.Format("{0}\t{1}\t{2}\t{3}", res2.GetName(0), res2.GetName(1), res2.GetName(2), res2.GetName(3))); //имена столбцов
            while (res2.Read()) //пока мы можем что-то считать получилось-не получилось
            {
                object i = res2.GetValue(0);
                object nplaneid = res2.GetValue(1);
                object nrouteid = res2.GetValue(2);
                object t = res2.GetValue(3);
                listBoxtable.Items.Add(String.Format("{0}\t{1}\t{2}\t{3}", i, nplaneid, nrouteid, t));
            }
            res2.Close();
            connection.Close();
        }
    }
}
