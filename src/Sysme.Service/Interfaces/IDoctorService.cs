﻿using Sysme.Service.DTOs.Doctors;

namespace Sysme.Service.Interfaces;

public interface IDoctorService
{
    Task<DoctorResultDto> AddAsync(DoctorCreationDto dto);
    Task<DoctorResultDto> ModifyAsync(DoctorUpdateDto dto);
    Task<bool> RemoveByIdAsync(long id);
    Task<DoctorResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<DoctorResultDto>> RetrieveAllAsync();
    Task<IEnumerable<DoctorResultDto>> SearchByQuery(string query);
    Task<List<Dictionary<string, bool>>> GetPlanAsync(long id);
}
