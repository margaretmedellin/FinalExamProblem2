//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalExamProblem2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FootballSchedule
    {
        public int Id { get; set; }
        public int Season { get; set; }
        public string Opponent { get; set; }
        public System.DateTime Date { get; set; }
        public bool IsHomeGame { get; set; }
    }
}
