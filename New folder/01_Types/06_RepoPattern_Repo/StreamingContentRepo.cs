using System;
using System.Collections.Generic;
using System.Text;

namespace _06_RepoPattern_Repo
{
    public class StreamingContentRepo
    {
        //below is called a Field- its like a property
        //Field= variable in the class that can be used anywhere

        private List<StreamingContent> _listOfContent = new List<StreamingContent>();
        
        //create
        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }
        //read
        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }
        //update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //find content
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            //update content
            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            { return false; }
        }

        //delete
        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if(content ==null)
            {
                return false;
            }
            
            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if(initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //helper method
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _listOfContent)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
    }
}
