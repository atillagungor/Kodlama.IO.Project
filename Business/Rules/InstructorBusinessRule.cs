namespace Business.Rules;

public class InstructorBusinessRules : BaseBusinessRules<Instructor>
{
    IInstructorDal _instructorDal;
    public InstructorBusinessRules(IInstructorDal instructorDal) : base(instructorDal)
    {
        _instructorDal = instructorDal;
    }
}