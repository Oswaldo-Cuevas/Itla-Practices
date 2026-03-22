using SoundJournal.Application.Dtos;
using SoundJournal.Application.Core;
using System.Collections.Generic;

namespace SoundJournal.Application.Contract
{
    public interface IDepartmentService
    {
        ServiceResult<IEnumerable<DepartmentDto>> GetAll();
        ServiceResult<DepartmentDto> GetById(int id);
        ServiceResult Add(DepartmentDto department);
        ServiceResult Update(DepartmentDto department);
        ServiceResult Delete(int id);
    }
}