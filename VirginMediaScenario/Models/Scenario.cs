using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VirginMediaScenario.Models
{
    public class Scenario
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Scenario Id")]
        public int ScenarioID { get; set; }
        [Display(Name = "Scenario")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string UserID { get; set; }     
        [Display(Name = "Sample Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? SampleDate { get; set; }
        [Display(Name = "Creation Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime? CreationDate { get; set; }
        [Display(Name = "Months")]
        public int? NumMonths { get; set; }
        [Display(Name = "Market Id")]
        public int? MarketID { get; set; }
        [Display(Name = "Network Layer Id")]
        public int? NetworkLayerID { get; set; }
    }
}
