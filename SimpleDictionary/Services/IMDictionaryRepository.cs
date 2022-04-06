using SimpleDictionary.Models.Entities;

namespace SimpleDictionary.Services
{
    public class IMDictionaryRepository : IDictionaryRepository
    {
        private static ICollection<DictionaryEntry> _dictionaryEntries
            = new List<DictionaryEntry>();
        public DictionaryEntry Create(DictionaryEntry entry)
        {
            _dictionaryEntries.Add(entry);
            return entry;
        }

        public ICollection<DictionaryEntry> ReadAll()
        {
            return _dictionaryEntries;
        }
    }
}
