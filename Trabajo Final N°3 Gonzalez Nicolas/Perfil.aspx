<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Trabajo_Final_N_3_Gonzalez_Nicolas.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div class=" p-3 m-auto bg-warning text-dark">

  <h1> <u> Perfil  </u></h1>


    <div class=" row">
        <div class=" col-4">
        
            <div class="mb-3">
                <label class="form-label ">Email:</label>
                <asp:TextBox runat="server" id="TxtEmail" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label class=" form-label ">Nombre:</label>
                <asp:TextBox runat="server" ID="TxtNombre" CssClass=" form-control"  />
            </div>

            <div class=" mb-3">
                <label  class=" form-label ">Apellido</label>
                <asp:TextBox runat="server" ID="TxtApellido" CssClass=" form-control"  />
            </div>

                <div class=" mb-3">
                <label  class=" form-label ">Telefono:</label>
                <asp:TextBox runat="server" ID="TextTelefono" CssClass=" form-control"  />
            </div>

             <div class=" mb-3">
                <label  class=" form-label ">Domicilio:</label>
                <asp:TextBox runat="server" ID="TextDomicilio" CssClass=" form-control"  />
            </div>

         

            </div>
       
    <div class="col-md-5">

          <div class=" mb-3">
                <label  class=" form-label ">Fecha de Nacimiento</label>
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" TextMode="Date" />
            </div>

        <div class=" mb-3">
            <label class="form-label">Imagen Perfil</label>
            <input type="file" Id="TxtImagen" runat="server" class="form-control" />
        </div>

        <asp:Image ID="ImgPerfil" ImageUrl="https://img.freepik.com/vector-premium/icono-perfil-usuario-estilo-plano-ilustracion-vector-avatar-miembro-sobre-fondo-aislado-concepto-negocio-signo-permiso-humano_157943-15752.jpg?w=740"
          runat="server" Width="50%" CssClass=" img-fluid mb-3" />
    </div>
        </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Button Text="Guardar"  runat="server" ID="BtnGuardar" CssClass="btn btn-primary" />
            <a href="/">Regresar</a>
        </div>
    </div>
 </div>
</asp:Content>
