using AFP_2018_C.Database.Entities;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_2018_C.Database
{
    public class MathQuestionsManager:BaseDatabaseManager
    {
        public List<MathQuestion> SelectAll()
        {
            List<MathQuestion> list = new List<MathQuestion>();
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM MATHQUESTIONS q INNER JOIN MATHANSWERS a ON (q.id=a.question_id)";
            command.Connection = this.getConnection();

            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    MathQuestion record = new MathQuestion();
                    record.Text = reader["question"].ToString();
                    record.Score = (int)reader["pont"];
                    record.Answers.Add(new MathAnswer(reader["answer"].ToString(), (bool)reader["is_correct"]));
                    list.Add(record);
                }
            }

            return list;
        }

        public bool Insert(MathQuestion question)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO MATHQUESTION(question, pont) VALUES(:text, :score);";

            OracleParameter text = new OracleParameter();
            text.ParameterName = ":text";
            text.DbType = System.Data.DbType.String;
            text.Value = question.Text;
            command.Parameters.Add(text);

            OracleParameter score = new OracleParameter();
            score.ParameterName = ":score";
            score.DbType = System.Data.DbType.String;
            score.Value = question.Score;
            command.Parameters.Add(score);

            command.Connection = getConnection();
            return command.ExecuteNonQuery() == -1;

        }

        public bool Delete(int id)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM MathQuestion WHERE id = :id;";

            OracleParameter idParam = new OracleParameter();
            idParam.ParameterName = ":id";
            idParam.DbType = System.Data.DbType.String;
            idParam.Value = id;
            command.Parameters.Add(idParam);

            command.Connection = getConnection();
            return command.ExecuteNonQuery() == -1;
        }

    }
}
