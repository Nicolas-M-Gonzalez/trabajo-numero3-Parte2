<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="ListadeArticulos.aspx.cs" Inherits="Trabajo_Final_N_3_Gonzalez_Nicolas.ListadeArticulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><u> lista de Articulos </u></h1>
    <asp:gridview id="DgvArticulo" runat="server" CssClass=" table" ></asp:gridview>
</asp:Content>
