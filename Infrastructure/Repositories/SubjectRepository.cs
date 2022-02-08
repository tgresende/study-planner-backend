using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using planner_web_api.Infrastructure.Interfaces;
using planner_web_api.Infrastructure.Context;

using backend.Domain.entities;

namespace planner_web_api.Infrastructure.Repositories
{
    public class SubjectRepository : ISubjectRepository
     {
        public AppDbContext context;

        public SubjectRepository(AppDbContext context){
            this.context = context;
        }

        public async Task<IEnumerable<Subject>> GetSubjects() 
        {
            return await context.Subject.ToListAsync();
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

        public async Task Delete(Subject subject) 
        {
            this.context.Subject.Remove(subject);
            context.SaveChanges();
        }
    }
}