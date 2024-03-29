﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMRFacade.Areas.app.Models
{
    public class PatientModel
    {
        List<object> lstObjParamters;
        List<NameValuePair> lstParameters;

        public List<PatientViewModel> Get()
        {
            return new RestSharpHandler().RestRequest<List<PatientViewModel>>(false, "api/Patient/Get", "GET", null);
        }
    }

    public class PatientViewModel
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string DOB { get; set; }
        public string MedicalRecordNumber { get; set; }
        public string Gender { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Physician { get; set; }
        public string Gurrantor { get; set; }
        public string Spouse { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public string EmergencyContact { get; set; }
        public string SecondaryName { get; set; }
        public string MaidenName { get; set; }
        public string Confidential { get; set; }
        public string MaritalStatus { get; set; }
        public string Smoker { get; set; }
        public string PrivacyNotice { get; set; }
        public string Military { get; set; }
        public string Race { get; set; }
        public string Religion { get; set; }
        public string Isolation { get; set; }
        public string BirthPlace { get; set; }
        public string Ethinicity { get; set; }
        public string Language { get; set; }
        public string Indigent { get; set; }
        public string DNR { get; set; }
        public string ExpiredDate { get; set; }
        public string PatientNote { get; set; }
        public string SocialInsuranceNumber { get; set; }
    }
}