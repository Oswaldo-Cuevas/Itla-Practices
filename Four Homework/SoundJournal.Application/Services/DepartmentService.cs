using SoundJournal.Application.Contract;
using SoundJournal.Application.Dtos;
using SoundJournal.Application.Core;
using SoundJournal.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SoundJournal.Application.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DepartmentRepository _repository;

        public DepartmentService(DepartmentRepository repository)
        {
            _repository = repository;
        }

        public ServiceResult<IEnumerable<DepartmentDto>> GetAll()
        {
            var departments = _repository.GetAll()
                .Select(d => new DepartmentDto { Id = d.Id, Name = d.Name });
            return ServiceResult<IEnumerable<DepartmentDto>>.SuccessResult(departments);
        }

        public ServiceResult<DepartmentDto> GetById(int id)
        {
            var department = _repository.GetById(id);
            if (department == null)
                return ServiceResult<DepartmentDto>.Failure("Department not found");

            var dto = new DepartmentDto { Id = department.Id, Name = department.Name };
            return ServiceResult<DepartmentDto>.SuccessResult(dto);
        }

        public ServiceResult Add(DepartmentDto department)
        {
            _repository.Add(new SoundJournal.Domain.Entities.Department
            {
                Id = department.Id,
                Name = department.Name
            });
            return ServiceResult<string>.SuccessResult("Department added successfully");
        }

        public ServiceResult Update(DepartmentDto department)
        {
            var updated = _repository.Update(new SoundJournal.Domain.Entities.Department
            {
                Id = department.Id,
                Name = department.Name
            });

            if (!updated) return ServiceResult<string>.Failure("Update failed");
            return ServiceResult<string>.SuccessResult("Department updated successfully");
        }

        public ServiceResult Delete(int id)
        {
            var deleted = _repository.Delete(id);
            if (!deleted) return ServiceResult<string>.Failure("Delete failed");
            return ServiceResult<string>.SuccessResult("Department deleted successfully");
        }
    }
}