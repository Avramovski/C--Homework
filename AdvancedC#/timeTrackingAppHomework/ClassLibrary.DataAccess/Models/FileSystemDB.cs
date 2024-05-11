

using ClassLibrary.DataAccess.Interfaces;
using ClassLibrary.Domain.DomainModels;
using Newtonsoft.Json;

namespace ClassLibrary.DataAccess.Models
{
    public class FileSystemDB<T> : IGenericDb<T> where T : BaseEntity
    {
        public int IdCounter { get; set; }
        public List<T> _db;
        private string _dbDirectory;
        private string _dbFile;
        private string _id;
        public FileSystemDB()
        {
            _dbDirectory = @"..\..\..\DataBase";
            _dbFile = $@"{_dbDirectory}\{typeof(T).Name}s.json";
            _id = _dbDirectory + @"\id.txt";
            if (!Directory.Exists(_dbDirectory))
            {
                Directory.CreateDirectory(_dbDirectory);
            }
            if (!File.Exists(_dbFile))
            {
                File.Create(_dbFile).Close();
            }
            if (!File.Exists(_id))
            {
                File.Create(_id).Close();
            }
        }
        public List<T> Read()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_dbFile))
                {
                    string data = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<T>>(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading database: " + ex.Message);
                return new List<T>();
            }
        }
        private void WriteData(string path, List<T> data)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(JsonConvert.SerializeObject(data));
            }
        }
        public bool Write(List<T> values)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_dbFile))
                {
                    string data = JsonConvert.SerializeObject(values);
                    sw.WriteLine(data);
                }
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public List<T> GetAll()
        {
            using (StreamReader sr = new StreamReader(_dbFile))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
        }
        public T GetById(int id)
        {
            return GetAll().SingleOrDefault(x => x.Id == id);
        }

        private int GenerateId()
        {
            int id = 1;
            string currentId = null;
            try
            {
                using (StreamReader sr = new StreamReader(_id))
                {
                    currentId = sr.ReadLine();
                }
                if (currentId != null && int.TryParse(currentId, out id))
                {
                   id++;
                }
                else
                {

                    Console.WriteLine("Invalid or missing ID file. Using default ID: 1");
                    id = 1;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error reading ID file: " + ex.Message);
                id = 1;
            }
          
            try
            {
                using (StreamWriter sw = new StreamWriter(_id))
                {
                    sw.WriteLine(id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing ID file: " + ex.Message);
            }

            return id;
        }
       
        public int Add(T entity)
        {
            try
            {
                List<T> data = Read(); 

                if (data == null)
                    data = new List<T>();

                entity.Id = GenerateId(); 
                data.Add(entity); 

                Write(data); 
                return entity.Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding entity: " + ex.Message);
                return -1; 
            }
        }


        public bool Update(T entity)
        {
            try
            {
                List<T> data = new List<T>();

                using (StreamReader sr = new StreamReader(_dbFile))
                {
                    data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
                }
                T item = data.SingleOrDefault(x => x.Id == entity.Id);
                if (item != null)
                {
                    data[data.IndexOf(item)] = entity;
                    WriteData(_dbFile, data);
                    return true;
                }
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
