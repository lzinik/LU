using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using PersonRepository.Entities;
using PersonRepository.Interfaces;

namespace PersonValidator
{
    public class SolucionAdvanced : SolucionBasic, IPersonRepositoryAdvanced
    {
        public bool isCapitalized(string fullName)
        {
            // if (fullName == fullName.ToUpper())
            //     return false;
            
            // https://docs.microsoft.com/en-us/dotnet/api/system.globalization.textinfo.totitlecase?view=netframework-4.8

            TextInfo myTI = new CultureInfo("en-US",false).TextInfo;

            return fullName == myTI.ToTitleCase( fullName );
        }
        public int[] GetNotCapitalizedIds()
        {
            List<int> notCapitalizedIds = new List<int>();

            foreach(Person p in People)
            {
                if(!isCapitalized(p.Name))
                    notCapitalizedIds.Add(p.Id);

            }
            return notCapitalizedIds.ToArray();
        }

        public int getPersonNameLength (Person p){
            return p.Name.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public int longestName (List<Person> People)
        {
            int lName = 0;
            for (int i = 0; i < People.Count(); i++)
            {
                lName = (lName > getPersonNameLength(People[i])) ? lName : getPersonNameLength(People[i]);
            }
            return lName;
        }
        public Dictionary<int, string[]> GroupEmailByNameCount()
        {
            var dic = new Dictionary<int, string[]>();
            int nameLength = 1;

            while (nameLength <= longestName(People))
            {
                List<string> emails = new List<string>();
                
                for(int j = 0; j < People.Count(); j++)
                {
                    if (nameLength == getPersonNameLength(People[j]) )
                        emails.Add(People[j].Email);
                }
                dic.Add(nameLength, emails.ToArray());
                nameLength++;
            }
            return dic;
        }
    }
}