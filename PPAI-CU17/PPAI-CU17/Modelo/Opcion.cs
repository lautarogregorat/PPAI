using PPAI_CU17.Modelo;

namespace PPAI_CU17.Modelo;
	public class Opcion
	{
		public Opcion()
		{
		}

		public string getDatos()
		{
			return "datos de opcion";
		}

		public void getCategoria(Categoria categoria)
		{
			categoria.getDatos();
		}
	}
