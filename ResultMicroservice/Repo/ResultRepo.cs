using ResultMicroservice.Model;
using System.Collections.Generic;

namespace ResultMicroservice.Repo
{
    public class ResultRepo : IResultRepo
    {
        public List<Result> GetResults()
        {
            return ResultCollection();    
        }

        private List<Result> ResultCollection()
        {
            return new List<Result>() {
            new Result(){StudentId=1,result = new Dictionary<string, string>(){
                { "Tamil", "Pass"},{ "English","Pass"},{ "Maths","Fail"} } },
            new Result(){StudentId=2,result = new Dictionary<string, string>(){
                { "Tamil", "Pass"},{ "English","Pass"},{ "Maths","Fail"} } },
            new Result(){StudentId=3,result = new Dictionary<string, string>(){
                { "Tamil", "Fail"},{ "English","Pass"},{ "Maths","Fail"} } },
            new Result(){StudentId=4,result = new Dictionary<string, string>(){
                { "Tamil", "Pass"},{ "English","Pass"},{ "Maths","Fail"} } },
            new Result(){StudentId=5,result = new Dictionary<string, string>(){
                { "Tamil", "Pass"},{ "English","Pass"},{ "Maths","Pass"} } },
            new Result(){StudentId=6,result = new Dictionary<string, string>(){
                { "Tamil", "Pass"},{ "English","Pass"},{ "Maths","Pass"} } },
            new Result(){StudentId=7,result = new Dictionary<string, string>(){
                { "Tamil", "Fial"},{ "English","Pass"},{ "Maths","Pass"} } }

            };
        }
    }

    public interface IResultRepo {

        public List<Result> GetResults();
    }
}
