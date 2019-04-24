﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DB55.ViewModel
{
    public class DiseasesModel
    {
        
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int DoctorId { get; set; }
        public int PredictionID { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Lookup Lookup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiseasePrediction> DiseasePredictions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicine> Medicines { get; set; }

        public static IEnumerable<SelectListItem> GetPredictionId()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new  SelectListItem{Text = "Disease", Value = "1" },
                new  SelectListItem{Text = "Condition", Value = "2" },
            };
            return items;
        }
    }
}