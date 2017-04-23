using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UNDPSerbia.Models
{
    public class ServiceContract
    {
        public int Id { get; set; }

        [Required]
        public int SCNumber { get; set; }

        [Required]
        public int SCYear { get; set; }

        [Required]
        public int AmendmentNo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Contract date")]
        public DateTime ContractDate { get; set; }

        [StringLength(50)]
        [Display(Name ="Contract Made on Behalf")]
        public string OnBehalf { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [StringLength(150)]
        [Display(Name = "Contractor Home Address")]
        public string ContractorAddress { get; set; }

        [StringLength(30)]
        public string ContractorPhone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Contract Start Date*")]
        public DateTime ContractStart { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Contract End Date*")]
        public DateTime ContractEnd { get; set; }

        [Required]
        [Display(Name = "Remuneration Gross")]
        public decimal RemunerationAmount { get; set; }

        [Required]
        [StringLength(3)]
        public string RemunerationCurrency { get; set; }

        [StringLength(50)]
        public string BeneficiaryName { get; set; }

        [StringLength(150)]
        public string BeneficiaryAddress { get; set; }

        [StringLength(150)]
        [Display(Name = "UNDP Signatory")]
        public string UNDPSignatory { get; set; }

        [StringLength(200)]
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }

        [Display(Name = "Keep Attendance Records")]
        public bool? KeepAttendRec { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Last Update")]
        public DateTime? LastUpdate { get; set; }

        [StringLength(30)]
        [Display(Name = "Last Updated By")]
        public string LastUpdatedBy { get; set; }

        [Display(Name = "Staff Location ")]
        public int? LocationID { get; set; }

        public int? ProjectGroup1 { get; set; }

        public int? Percentage1 { get; set; }

        public int? ProjectGroup2 { get; set; }

        public int? Percentage2 { get; set; }

        public int? ProjectGroup3 { get; set; }

        public int? Percentage3 { get; set; }

        public DateTime? TwoMonthsReminder { get; set; }

        public int? BuildingID { get; set; }

        [StringLength(50)]
        [Display(Name = "Duty Station")]
        public string DutyStation { get; set; }

        public int? EmailRequestID { get; set; }

        public DateTime? PBDate { get; set; }

        [StringLength(200)]
        [Display(Name = "ISS Charges")]
        public string ISScharges { get; set; }
    }
}