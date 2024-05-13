<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="ListaArticulo.aspx.cs" Inherits="Trabajo_Final_N_3_Gonzalez_Nicolas.ListaArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class=" p-3 m-auto bg-warning text-dark">
    <h1><u> lista de Articulos </u></h1>
       </div>

     <asp:GridView  ID="DgvArticulo" runat="server" CssClass="table"
        AutoGenerateColumns="false" DataKeyNames="Id"
        OnSelectedIndexChanged="DgvArticulo_SelectedIndexChanged"
        OnPageIndexChanging="DgvArticulo_PageIndexChanging"
        AllowPaging="true" PageSize="10">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
            <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
            <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />
            <asp:BoundField HeaderText="Precio" DataField="Precio" />
            <asp:CommandField HeaderText="Modificar" ShowSelectButton="true" SelectText="✒️" />
        </Columns>
    </asp:GridView>
    <a href="formulario.aspx" class="btn btn-primary">Agregar</a>
</asp:Content>

