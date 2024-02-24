using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.Instructor;
using Business.Dtos.Response.Instructor;
using Core.Paging;

namespace Business.Concrete;

public class InstructorManager : IInstructorService
{
    IMapper _mapper;
    IInstructorDal _instructorDal;
    public InstructorManager(IMapper mapper, IInstructorDal instructorDal)
    {
        _mapper = mapper;
        _instructorDal = instructorDal;
    }
    public async Task<CreatedInstructorResponse> AddAsync(CreateInstructorRequest createInstructorRequest)
    {
        Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
        var createdInstructor = await _instructorDal.AddAsync(instructor);
        CreatedInstructorResponse result = _mapper.Map<CreatedInstructorResponse>(createdInstructor);
        return result;
    }

    public async Task<DeletedInstructorResponse> DeleteAsync(DeleteInstructorRequest deleteInstructorRequest)
    {
        Instructor instructor = await _instructorBusinessRules.CheckIfExistsById(deleteInstructorRequest.Id);
        var deletedInstructor = await _instructorDal.DeleteAsync(instructor);
        DeletedInstructorResponse deletedInstructorResponse = _mapper.Map<DeletedInstructorResponse>(deletedInstructor);
        return deletedInstructorResponse;
    }

    public async Task<IPaginate<GetListInstructorResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _instructorDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListInstructorResponse>>(result);
    }

    public async Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest)
    {
        Instructor instructor = await _instructorBusinessRules.CheckIfExistsById(updateInstructorRequest.Id);
        _mapper.Map(updateInstructorRequest, instructor);
        var updatedInstructor = await _instructorDal.UpdateAsync(instructor);
        UpdatedInstructorResponse updatedInstructorResponse = _mapper.Map<UpdatedInstructorResponse>(updatedInstructor);
        return updatedInstructorResponse;
    }
}