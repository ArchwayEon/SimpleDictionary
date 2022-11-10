
using SimpleDictionary.Models.Entities;

namespace SimpleDictionary.Services;

public interface IDictionaryRepository
{
    ICollection<DictionaryEntry> ReadAll();
    DictionaryEntry Create(DictionaryEntry entry);
}
