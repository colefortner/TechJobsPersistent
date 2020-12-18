using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobSkillViewModel
    {
        [Required(ErrorMessage = "Job is required")]
        public int JobId { get; set; }

        [Required(ErrorMessage = "Skill is required")]
        public int SkillId { get; set; }

        public Job Job { get; set; }
        // Renders the Skills in the dropdown
        public List<SelectListItem> Skills { get; set; }

        public AddJobSkillViewModel(Job theJob, List<Skill> possibleSkills)
        {
            Skills = new List<SelectListItem>();
            // loops through possible skills
            foreach (var skill in possibleSkills)
            {// add a new skll
                Skills.Add(new SelectListItem
                {
                    Value = skill.Id.ToString(),
                    // text you see in the dropdown menu
                    Text = skill.Name
                });
            }

            Job = theJob;
        }

        public AddJobSkillViewModel()
        {
        }
    }
}
