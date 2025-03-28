using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

public class CATEGORIE
{
	public int K_Categoria;
	public string Categoria;

	public CATEGORIE()
	{
	}
	//SelectAll
	public DataTable SelectAll()
	{
		DB db = new DB();
		db.query = "Categorie_SelectAll";
		return db.SQLselect();
	}
	//Verifica per inserimento
	public DataTable Verifica()
	{
		DB db = new DB();
		db.query = "Categorie_Verifica";
		db.cmd.Parameters.AddWithValue("@cat", Categoria);
		return db.SQLselect();
	}
	//Inserimento
	public void Insert()
	{
		DB db = new DB();
		db.query = "Categorie_Insert";
		db.cmd.Parameters.AddWithValue("@cat", Categoria);
		db.Sqlcommand();
	}
	//Select per chiave
	public DataTable SelectChiave()
	{
		DB db = new DB();
		db.query = "Categorie_SelectChiave";
		db.cmd.Parameters.AddWithValue("@chiave", K_Categoria);
		return db.SQLselect();
	}
    //Verifica per update
    public DataTable VerificaUpdate()
	{
		DB db = new DB();
		db.query = "Categorie_VerificaUpdate";
        db.cmd.Parameters.AddWithValue("@chiave", K_Categoria);
        db.cmd.Parameters.AddWithValue("@cat", Categoria);
		return db.SQLselect();
    }
	//Update
	public void Update()
	{
		DB db = new DB();
		db.query = "Categorie_Update";
        db.cmd.Parameters.AddWithValue("@chiave", K_Categoria);
        db.cmd.Parameters.AddWithValue("@cat", Categoria);
		db.Sqlcommand();
    }
}