using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public int JobId { get; set; }

        public int EmployerId { get; set; }

        public string Name { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public List<Skill> Skills { get; set; }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Skills = skills;
            Employers = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        // Value is the form value, when the form is submitted and the text will be the display value (in the dropdown)
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    }
                );
            }
        }



        public AddJobViewModel()
        {
        }
    }
}
