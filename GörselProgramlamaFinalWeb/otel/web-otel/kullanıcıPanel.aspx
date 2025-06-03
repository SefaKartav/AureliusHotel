<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kullanıcıPanel.aspx.cs" Inherits="otel.web_otel.kullanıcıPanel" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Kullanıcı Paneli</title>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;600;700&display=swap" rel="stylesheet">
    <style>
        body {
            font-family: 'Poppins', sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f5f5f5;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
        }

        .panel {
            background: #fff;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
            max-width: 900px;
            width: 100%;
            margin: 40px;
            text-align: center;
        }

        .header {
            font-size: 28px;
            font-weight: 700;
            color: #333;
            margin-bottom: 20px;
        }

        .welcome {
            font-size: 20px;
            font-weight: 600;
            color: #333;
            margin-bottom: 20px;
        }

        .back-button {
            display: inline-block;
            background-color: #ebef0c;
            color: #333;
            padding: 10px 20px;
            border-radius: 5px;
            text-decoration: none;
            font-weight: 600;
            transition: background-color 0.3s;
            margin-bottom: 20px;
        }

        .back-button:hover {
            background-color: #d6d80c;
        }

        .btn {
            background-color: #ebef0c;
            color: #333;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            font-weight: 600;
            cursor: pointer;
            transition: background-color 0.3s;
            text-transform: uppercase;
        }

        .btn:hover {
            background-color: #d6d80c;
        }

        table {
            width: 100%;
            border-collapse: separate;
            border-spacing: 0;
            margin-top: 20px;
            border-radius: 8px;
            overflow: hidden;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
        }

        th, td {
            border: 1px solid #ddd;
            padding: 12px;
            font-size: 14px;
            text-align: left;
        }

        th {
            background-color: #ebef0c;
            color: #333;
            font-weight: 600;
        }

        td {
            background-color: #fff;
            color: #666;
        }

        @media (max-width: 768px) {
            .panel {
                margin: 20px;
                padding: 20px;
            }

            table {
                font-size: 12px;
            }
        }

        @media (max-width: 480px) {
            th, td {
                padding: 8px;
            }
        }

        .rezervasyon-tablosu {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
        }

        .rezervasyon-tablosu th, .rezervasyon-tablosu td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
        }

        .rezervasyon-tablosu th {
            background-color: #f2f2f2;
        }

        .iptal-btn {
            background-color: #ff4d4d;
            color: white;
            border: none;
            padding: 5px 10px;
            cursor: pointer;
            border-radius: 3px;
        }

        .iptal-btn:hover {
            background-color: #cc0000;
        }

        .iptal-edildi {
            color: #ff4d4d;
            font-weight: 600;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
        <div class="panel">
            <div class="header">Kullanıcı Paneli</div>
            <a href="otel.aspx" class="back-button">Geri</a>
            <div class="welcome">Hoş geldin, <asp:Label ID="lblKullaniciAdi" runat="server" Text=""></asp:Label>!</div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" CssClass="rezervasyon-tablosu">
                <Columns>
                    <asp:BoundField DataField="ad" HeaderText="Ad" />
                    <asp:BoundField DataField="soyad" HeaderText="Soyad" />
                    <asp:BoundField DataField="email" HeaderText="E-posta" />
                    <asp:BoundField DataField="giris_tarihi" HeaderText="Giriş Tarihi" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="cikis_tarihi" HeaderText="Çıkış Tarihi" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="oda_tipi" HeaderText="Oda Tipi" />
                    <asp:BoundField DataField="toplam_tutar" HeaderText="Toplam Tutar" DataFormatString="{0:N2} €" />
                    <asp:TemplateField HeaderText="İşlem">
                        <ItemTemplate>
                            <asp:Button ID="btnIptal" runat="server" Text="İptal Et" Visible="false" CssClass="iptal-btn" OnClientClick='<%# "cancelReservation(" + Eval("id") + ", this); return false;" %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="btnCikis" runat="server" Text="Çıkış Yap" CssClass="btn" OnClick="btnCikis_Click" />
        </div>
        <script type="text/javascript">
            function cancelReservation(id, button) {
                if (confirm("Bu rezervasyonu iptal etmek istediğinizden emin misiniz?")) {
                    PageMethods.RezervasyonIptal(id, onSuccess, onError);

                    function onSuccess(result) {
                        alert(result);
                        // Butonun bulunduğu hücreyi (td) bul ve "İptal Edildi" yazısıyla değiştir
                        var cell = button.parentNode;
                        cell.innerHTML = '<span class="iptal-edildi">İptal Edildi</span>';
                    }

                    function onError(error) {
                        alert("Hata: " + error.get_message());
                    }
                }
            }
        </script>
    </form>
</body>
</html>