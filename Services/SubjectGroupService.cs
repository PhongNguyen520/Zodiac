using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SubjectGroupService : ISubjectGroupService
    {
        private readonly ISubjectGroupRepository _subjectGroupRepository;

        public SubjectGroupService(SubjectGroupRepository subjectGroupRepository)
        {
            _subjectGroupRepository = subjectGroupRepository;
        }

        public bool AddSubjectGroup(SubjectGroup subjectGroup)
        {
            return _subjectGroupRepository.AddSubjectGroup(subjectGroup);
        }

        public bool DelSubjectGroups(int id)
        {
            return _subjectGroupRepository.DelSubjectGroups(id);
        }

        public List<SubjectGroup> GetSubjectGroups()
        {
            return _subjectGroupRepository.GetSubjectGroups();
        }

        public bool UpdateSubjectGroups(SubjectGroup subjectGroup)
        {
            return _subjectGroupRepository.UpdateSubjectGroups(subjectGroup);
        }
    }
}
