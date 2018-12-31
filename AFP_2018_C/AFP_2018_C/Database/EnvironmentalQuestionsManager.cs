using AFP_2018_C.Database.Entities;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_2018_C.Database
{
    public class EnvironmentalQuestionsManager : BaseDatabaseManager
    {
        public List<EnvironmentalQuestion> SelectAll()
        {
            List<EnvironmentalQuestion> list = new List<EnvironmentalQuestion>();
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM ENVIRONMENTALQUESTIONS q INNER JOIN MATHANSWERS a ON (q.id=a.question_id)";
            command.Connection = this.getConnection();

            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    EnvironmentalQuestion record = new EnvironmentalQuestion();
                    record.Text = reader["question"].ToString();
                    record.Score = (int)reader["pont"];
                    record.Answers.Add(new EnvironmentalAnswer(reader["answer"].ToString(), (bool)reader["is_correct"]));
                    list.Add(record);
                }
            }

            return list;
        }

        public EnvironmentalQuestion Select(int index)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM ENVIRONMENTALQUESTIONS " +
                "WHERE id=:id";

            OracleParameter id = new OracleParameter();
            id.ParameterName = ":id";
            id.DbType = System.Data.DbType.Int32;
            id.Value = index;
            command.Parameters.Add(id);

            command.Connection = this.getConnection();

            EnvironmentalQuestion question = null;

            OracleDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                question = new EnvironmentalQuestion();
                question.Text = reader["text"].ToString();
                question.Score = int.Parse(reader["score"].ToString());
                //TODO a valaszok listava alakitasa kell meg
                question.Answers = new List<EnvironmentalAnswer>();
            }

            return question;
        }

        public bool Insert(EnvironmentalQuestion question)
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO ENVIRONMENTALQUESTIONS(question, pont) VALUES(:text, :score);";

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
            command.CommandText = "DELETE FROM EnvironmentalQuestion WHERE id = :id;";

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
