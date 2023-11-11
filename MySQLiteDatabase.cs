using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8PatientInfo
{
    class MySQLiteDatabase
    {
        public SQLiteConnection dbConnection;
        public const string DB_FILENAME = "MyDB.db3";
        public const SQLiteOpenFlags FLAGS = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.ReadOnly | SQLiteOpenFlags.SharedCache;
        public string dbPath = "";
        //public String currentState

        public const string PATIENT_TABLE = "Patient";
        public const string ID_COL = "ID";
        public const string NAME_COL = "Name";
        public const string DOB_COL = "DOB";
        public const string GENDER_COL = "Gender";
        public const string INCOME_COL = "Income";
        public const string BMI_COL = "BMI";

        public MySQLiteDatabase()
        {
            init();
        }
        public void init()
        {
            dbPath = System.IO.Path.Combine(FileSystem.AppDataDirectory, DB_FILENAME);
            dbConnection = new SQLiteConnection(dbPath);
            dbConnection.CreateTable<Patient>();
        }

        public int insertPatient(Patient p)
        {
            return dbConnection.Insert(p);
        }
        public ObservableCollection<Patient> loadPatient() {
            return (new ObservableCollection<Patient>(dbConnection.Table<Patient>().ToList()));    
        }
    }
}
