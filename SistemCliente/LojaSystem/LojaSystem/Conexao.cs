/*
 * Created by SharpDevelop.
 * User: Administrador
 * Date: 07/10/2021
 * Time: 14:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using MySql.Data.MySqlClient;

namespace LojaSystem
{
	/// <summary>
	/// Description of Conexao.
	/// </summary>
	public class Conexao
	{
		private String usuario;
		private String senha;
		private String host;
		private String banco;
		private MySqlConnection conexao;
		
		public Conexao()
		{
			this.usuario="root";
			this.senha="";
			this.host="localhost";
			this.banco="sistema";                                                                                                                            
		}
		public MySqlConnection conectar(){
			this.conexao= new MySqlConnection(	
				"server="+this.host+";user="+this.usuario+";database="+this.banco+";port=3306;password="+this.senha);
			return this.conexao;
			)
		}
		
		public void desconectar(){
			
			this.conexao.Close();
		}
	}
}
