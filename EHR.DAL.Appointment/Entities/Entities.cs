using EHR.DAL.Entities;
using EHR.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHR.DAL.Appointment.Entities
{
    public class Visit : ManagedEntity
    {
        public string Title { get; set; }
        public int EventId { get; set; }

        public User ProviderUser { get; set; }
        public User PatientUser { get; set; }

        public VisitType VisitType { get; set; }
        public VisitGroup VisitGroup { get; set; }

        public ICollection<VisitNote> VisitNote { get; set; }
        public ICollection<Symptom> Symptoms { get; set; }
        public ICollection<Diagnosis> Diagnoses { get; set; }
        public ICollection<Perscription> Perscriptions { get; set; }
    }

    public class VisitType : TypeEntity
    {

    }

    public class VisitGroup : ManagedEntity
    {
        public ICollection<Visit> Visit { get; set; }
    }

    public class VisitNote : ManagedEntity
    {
        public string Note { get; set; }

        public Visit Visit { get; set; }
    }

    public class Symptom : ManagedEntity
    {
        public Visit Visit { get; set; }
        public SymptomType SymptomType { get; set; }
    }

    public class SymptomType : TypeEntity
    {
    }

    public class Diagnosis : ManagedEntity
    {
        public Visit Visit { get; set; }
        public Ailment Ailment { get; set; }
    }

    public class Ailment : ManagedEntity
    {

    }

    public class Treatment : ManagedEntity
    {
        public Visit Visit { get; set; }
        public ICollection<TreatmentPoint> TreatmentPoints { get; set; }
    }

    public class TreatmentPoint : ManagedEntity
    {
        public Treatment Treatment { get; set; }
        public Point Point { get; set; }
    }

    public class Point : ManagedEntity
    {
        public Channel Channel { get; set; }
    }

    public class Channel : ManagedEntity
    {
        public ICollection<Point> Points { get; set; }
    }

    public class Perscription : ManagedEntity
    {
        public Visit Visit { get; set; }
        public Formula Formula { get; set; }
    }

    public class Formula : ManagedEntity
    {
        public Perscription Perscription { get; set; }

        public ICollection<FormulaHerb> Herbs { get; set; }
    }

    public class FormulaHerb : ManagedEntity
    {
        public Formula Formula { get; set; }
        public Herb Herb { get; set; }
    }

    public class Herb : ManagedEntity
    {

    }
}
