﻿using Sysme.Domain.Commons;
using Sysme.Domain.Entities.Doctors;
using Sysme.Domain.Entities.Patients;
using System.Text.Json.Serialization;

namespace Sysme.Domain.Entities.Hospitals;

public class Hospital : AudiTable
{
    public string Name { get; set; }
    public string Address { get; set; }

    [JsonIgnore]
    public ICollection<Patient> Patients { get; set; }
    [JsonIgnore]
    public ICollection<Doctor> Doctors { get; set; }
}