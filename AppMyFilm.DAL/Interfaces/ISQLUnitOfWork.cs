using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;

namespace SkillManagement.DataAccess.Interfaces
{
    public interface ISQLUnitOfWork
    {
        ISQLEmployeeRepository SQLEmployeeRepository { get; }
        ISQLEmployeeSkillRepository SQLEmployeeSkillRepository { get; }
        ISQLSkillRepository SQLSkillRepository { get; }
        ISQLScoreRepository SQLScoreRepository { get; }
        ISQLFilmsRepository SQLFilmsRepository { get; }

        void Complete();
    }
}
