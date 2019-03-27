﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RLDT;

namespace RLDT.Experiments
{
    public class CsvStreamReader
    {
        //Fields
        private StreamReader file = null;
        private string[] headers = null;
        private double[] weights = null;
        private Dictionary<string,int> fieldNames = new Dictionary<string, int>(); //first line of csv file
        private Dictionary<string,int> fieldImportances = new Dictionary<string, int>(); //first line of csv file
        private int lineCounter = 0;

        //Constructor
        public CsvStreamReader(string csvAddress)
        {
            //Open csv file
            file = new System.IO.StreamReader(csvAddress);

            //Read headers
            string[] firstRowHeaders = file.ReadLine().Split(',');//.ToDictionary();//.Select((k, v) => new object[] { "hhh", 5 }).ToDictionary();//.ToDictionary(v=> v, (k,v)=> 5);
            for (int i=0; i<firstRowHeaders.Count(); i++)
            {
                string fieldName = firstRowHeaders[i].Trim();
                int column = i;

                if(fieldName.ToLower().EndsWith(":importance"))
                {
                    fieldName = fieldName.Substring(0, fieldName.LastIndexOf(":importance"));
                    if (!fieldImportances.ContainsKey(fieldName))
                        fieldImportances.Add(fieldName, column);
                }
                else
                {
                    if (!fieldNames.ContainsKey(fieldName))
                        fieldNames.Add(fieldName, column);
                }
                    
            }
            
            //Create dictionary of headers with column location
            //featureNames = headers.Where(p => p.ToLower().IndexOf(":importance") < 0).ToArray();
            //weights = file.ReadLine().Split(',').Select(double.Parse).ToArray();
        }

        //Properties
        public int LineNumber
        {
            get { return lineCounter; }
        }
        public bool EndOfStream
        {
            get { return file.EndOfStream; }
        }

        //Methods
        public DataVector ReadLine()
        {
            //Try to read a line
            string line = file.ReadLine();
            if (line == null)
                return null;

            //Read a line to a string array
            string[] dataobjects = line.Split(',');
            lineCounter++;

            //Build datavector
            DataVector dv = new DataVector();
            foreach (var fieldNameKVP in fieldNames)
            {
                string name = fieldNameKVP.Key;
                string value = dataobjects[fieldNameKVP.Value];
                dv.AddFeature(name, value);
            }
            return dv;
        }
        public DataVectorTraining ReadLine(string labelFeatureName)
        {
            //Try to read a line
            string line = file.ReadLine();
            if (line == null)
                return null;

            //Read a line to a string array
            string[] dataobjects = line.Split(',');
            lineCounter++;

            //Build Datavector
            DataVectorTraining dvt = new DataVectorTraining();
            foreach(var fieldNameKVP in fieldNames)
            {
                string name = fieldNameKVP.Key;
                string value = dataobjects[fieldNameKVP.Value];
                double importance = 0;
                if (fieldImportances.ContainsKey(name))
                    double.TryParse(dataobjects[fieldImportances[name]], out importance);
                dvt.AddFeature(name, value, importance);
            }
            dvt.SetLabel(labelFeatureName, dvt[labelFeatureName].Value);
            return dvt;
        }
        public void Close()
        {
            file.Close();
        }
        public void SeekOriginBegin()
        {
            file.BaseStream.Seek(0, SeekOrigin.Begin);
            file.ReadLine();
            file.ReadLine();
            lineCounter = 0;
        }
    }
}
