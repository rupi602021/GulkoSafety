﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GulkoSafety.Models
{
    public class project
    {
        int project_num;
        string name;
        string company;
        string address;
        DateTime start_date;
        DateTime end_date;
        int status;
        string description;
        float safety_lvl;
        int project_type_num;
        string manager_email;
        string foreman_email;

        public project(int project_num, string name, string company, string address, DateTime start_date, DateTime end_date, int status, string description, float safety_lvl, int project_type_num, string manager_email, string foreman_email)
        {
            Project_num = project_num;
            Name = name;
            Company = company;
            Address = address;
            Start_date = start_date;
            End_date = end_date;
            Status = status;
            Description = description;
            Safety_lvl = safety_lvl;
            Project_type_num = project_type_num;
            Manager_email = manager_email;
            Foreman_email = foreman_email;
        }

        public int Project_num { get => project_num; set => project_num = value; }
        public string Name { get => name; set => name = value; }
        public string Company { get => company; set => company = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Start_date { get => start_date; set => start_date = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }
        public int Status { get => status; set => status = value; }
        public string Description { get => description; set => description = value; }
        public float Safety_lvl { get => safety_lvl; set => safety_lvl = value; }
        public int Project_type_num { get => project_type_num; set => project_type_num = value; }
        public string Manager_email { get => manager_email; set => manager_email = value; }
        public string Foreman_email { get => foreman_email; set => foreman_email = value; }

        public project() { }

        public List<project> Read()
        {
            DBServices dbs = new DBServices();
            return dbs.ReadProjects();
        }

        public void Insert()
        {
            DBServices dbs = new DBServices();
            dbs.InsertProject(this);
        }
    }
}