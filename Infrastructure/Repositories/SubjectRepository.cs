using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using planner_web_api.Infrastructure.Interfaces;
using planner_web_api.Infrastructure.Context;

using backend.Domain.entities;
using backend.Domain.ResponseModels.Subjects;
using planner_web_api.Domain.entities;


namespace planner_web_api.Infrastructure.Repositories
{
    public class SubjectRepository : ISubjectRepository
     {
        public AppDbContext context;

        public SubjectRepository(AppDbContext context){
            this.context = context;
        }

        public async Task<List<GetSubjectsResponseModel>> GetSubjects(Project project) 
        {
            return await this.context.Subject
                .Where( sub => sub.project == project)
                .Select(sub => new GetSubjectsResponseModel{
                    SubjectId = sub.SubjectId,
                    Name = sub.Name
                }).ToListAsync();
        }

        public async Task<Subject> InsertSubject(Subject subject) 
        {
            context.Subject.Add(subject);
            await context.SaveChangesAsync();
            return subject;
        }

        public async Task<Subject> GetSubject(int subjectId) 
        {
            Subject subject = await this.context.Subject
                .FirstOrDefaultAsync( subject => subject.SubjectId == subjectId);
            return subject;
        }

        public async Task Delete(int subjectId) 
        {
            Subject subject = await this.context.Subject
                .FirstOrDefaultAsync( subject => subject.SubjectId == subjectId);

            this.context.Subject.Remove(subject);
            context.SaveChanges();
        }
    }
}