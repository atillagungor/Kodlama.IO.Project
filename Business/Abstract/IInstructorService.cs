using Business.Dtos.Request.Instructor;
using Business.Dtos.Response.Instructor;
using Core.Paging;

namespace Business.Abstract;

public interface IInstructorService
{
    Task<CreatedInstructorResponse> AddAsync(CreateInstructorRequest createInstructorRequest);
    Task<IPaginate<GetListInstructorResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedInstructorResponse> DeleteAsync(DeleteInstructorRequest deleteInstructorRequest);
    Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest);
}