//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMRData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Policy
    {
        public int PolicyID { get; set; }
        public int ProviderID { get; set; }
        public string ContractNumber { get; set; }
        public string Primary { get; set; }
        public string GroupInfo { get; set; }
        public string DirectPay { get; set; }
        public string BenefitsDetails { get; set; }
        public string PayerID { get; set; }
        public string FullDays { get; set; }
        public string CODays { get; set; }
        public string LifeDays { get; set; }
        public string BloodDeduct { get; set; }
        public string PartADeduct { get; set; }
        public string COPayRate { get; set; }
        public string COPayLimit { get; set; }
        public string SemiPrivateRate { get; set; }
        public string PerDimeRate { get; set; }
        public string LifeDaysUsed { get; set; }
        public string CoveredDays { get; set; }
        public string NonCovDays { get; set; }
        public string CoDaysUsed { get; set; }
        public string EffectiveDate { get; set; }
        public string CoveragePercentage { get; set; }
        public string DateCareEnded { get; set; }
        public string CoveredRoomRate { get; set; }
        public string PriorPayment { get; set; }
        public string PriorPaymentCode { get; set; }
        public string SpecialProgramID { get; set; }
        public string EPSDTReferralGiven { get; set; }
        public string EPSDTCCC { get; set; }
        public string PSROApprovalForm { get; set; }
        public string PSROApprovalTo { get; set; }
        public string LTCHCoverageEnd { get; set; }
        public string DelayReason { get; set; }
        public int ProviderProviderID { get; set; }
        public int ProviderProviderID1 { get; set; }
    
        public virtual Provider Provider { get; set; }
    }
}