using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
			if (listaSerie.Count == 0)
				throw new Exception("Lista de séries vazia.");

			if (id >= listaSerie.Count || id < 0)
				throw new Exception("Id inválido");

			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			if (listaSerie.Count == 0)
				throw new Exception("Lista de séries vazia.");

			if (id >= listaSerie.Count || id < 0)
				throw new Exception("Id inválido");

			if (listaSerie[id].retornaExcluido())
				throw new Exception("Este Id já foi excluído anteriormente do sistema.");

			listaSerie[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			if (listaSerie.Count == 0)
				throw new Exception("Lista de séries vazia.");

			if (id >= listaSerie.Count || id < 0)
				throw new Exception("Id inválido");

			return listaSerie[id];
		}
	}
}