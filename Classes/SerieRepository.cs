using System;
using System.Collections.Generic;
using Series.Interface;
namespace Series{
    public class SerieRepository: IRepository<Serie> 
    {
      private List<Serie> listaSerie = new List<Serie>();  
      public void Refresh (int id, Serie objeto){
          listaSerie[id] = objeto;
      }
      public void Delete(int id){
          listaSerie[id].isDeleted();
      } 
      public void Insert( Serie objeto){
          listaSerie.Add(objeto);
      } 
      public List<Serie> Lista(){
          return listaSerie;
      } 
      public int NextId(){
          return listaSerie.Count;
      } 
      public Serie ReturnWithId(int id) {
          return listaSerie[id];
      }
    }
}