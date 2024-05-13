<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Trabajo_Final_N_3_Gonzalez_Nicolas.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="update" runat="server"></asp:ScriptManager>
    
    

<div class=" p-3 m-auto bg-warning text-dark">

          
            <h1><u> Formulario </u></h1>
            
    
    <div class="row">
        <div class="col-6">

          

            <div class="mb-3">
                <label for="TxtId" class="form-label ">Id:</label>
                <asp:TextBox runat="server" ID="TxtId" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="TxtNombre" class=" form-label ">Nombre:</label>
                <asp:TextBox runat="server" ID="TxtNombre" CssClass=" form-control" />
            </div>

            <div class=" mb-3">
                <label for="TxtNumero" class=" form-label ">Codigo:</label>
                <asp:TextBox runat="server" ID="TxtCodigo" CssClass=" form-control" />
            </div>

            <div class="mb-3">
                <label for="TxtId" class="form-label ">Precio:</label>
                <asp:TextBox runat="server" ID="TxtPrecio" CssClass="form-control" />
            </div>

            <div class=" mb-3">
                <label for="DdlDebilidad" class=" form-label ">Marca:</label>
                <asp:DropDownList ID="DdlMarca" CssClass="form-select" runat="server" />
            </div>

             

            <div class=" mb-3">
                <label for="DdlTipo" class=" form-label ">Categoria</label>
                <asp:DropDownList ID="DdlCategoria" CssClass="form-select" runat="server" />
            </div>
        </div>


      
        <div class=" col-6">
            <div class=" mb-3">
                <label for="TxtDescripcion" runat="server" class="form-label">Descripción:</label>
                <asp:TextBox runat="server" CssClass=" form-control" TextMode="MultiLine" ID="TxtDescripción"></asp:TextBox>
            </div>
            <asp:UpdatePanel ID="UpdatePanel" runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="LblImagen" runat="server" class="form-label">Imagen</label>
                        <asp:TextBox runat="server" ID="TxtImagen" CssClass="form-control" AutoPostBack="true" 
                            OnTextChanged="TxtImagen_TextChanged"></asp:TextBox>
                    </div>
                    
                    <asp:Image ImageUrl="https://www.shutterstock.com/image-vector/default-ui-image-placeholder-wireframes-600nw-1037719192.jpg"
                        runat="server" ID="ImagenArticulo" Width="50%" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    
        <div class="col-3">

            <div class="mb-3">
                <asp:Button Text="Aceptar" CssClass="btn btn-primary" ID="BtnAceptar" OnClick="BtnAceptar_Click" runat="server" />
                <asp:Button Text="Cancelar" CssClass="btn   btn-primary" ID="Btncancelar"  runat="server" />
                <asp:Button Text="Inactivar" CssClass=" btn btn-dark" ID="BtnInactivar"  runat="server" />
            </div>

            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                     <asp:Button Text="Eliminar" CssClass=" btn-danger" ID="BtnEliminar" OnClick="BtnEliminar_Click"  runat="server" />
                    </div>

                    <%if (Eliminacion){   %>
                    
                         <div class="mb-3">
                        <asp:CheckBox Text = "Confirmar Eliminacion" runat="server" ID="CkEliminacion" />
                        <asp:Button Text = "Eliminar" CssClass=" btn btn-outline-danger" ID="ConfirmaEliminacion" OnClick="ConfirmaEliminacion_Click" runat="server" />
                        </div>
                   <% } %>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    
    </div>

</asp:Content>
