<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="otel.WebForm2" %>

<!DOCTYPE html>
<html lang="tr">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Giriş / Kayıt</title>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;600;700&display=swap" rel="stylesheet">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.12.5/gsap.min.js"></script>
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

        .container {
            background: #fff;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
            width: 100%;
            max-width: 400px;
            margin: 20px;
            opacity: 0;
        }

        .form-container {
            display: none;
        }

        .form-container.active {
            display: block;
        }

        h2 {
            text-align: center;
            font-size: 24px;
            font-weight: 600;
            color: #333;
            margin-bottom: 20px;
        }

        input, .aspNetButton {
            width: 100%;
            padding: 12px;
            margin: 10px 0;
            border-radius: 5px;
            border: 1px solid #ddd;
            font-size: 16px;
            box-sizing: border-box;
            transition: border-color 0.3s;
        }

        input:focus {
            border-color: #ebef0c;
            outline: none;
        }

        .aspNetButton {
            background-color: #ebef0c;
            color: #333;
            border: none;
            cursor: pointer;
            font-weight: 600;
            text-transform: uppercase;
            transition: background-color 0.3s;
        }

        .aspNetButton:hover {
            background-color: #d6d80c;
        }

        .switch-link {
            text-align: center;
            margin-top: 15px;
            font-size: 14px;
            color: #666;
            cursor: pointer;
            transition: color 0.3s;
        }

        .switch-link:hover {
            color: #ebef0c;
        }

        @media (max-width: 480px) {
            .container {
                padding: 20px;
                max-width: 300px;
            }

            h2 {
                font-size: 20px;
            }

            input, .aspNetButton {
                padding: 10px;
                font-size: 14px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" id="formBox">

            <!-- GİRİŞ FORMU -->
            <div id="girisForm" class="form-container active">
                <h2>Giriş Yap</h2>
                <asp:TextBox ID="txtGirisKullaniciAdi" runat="server" Placeholder="Kullanıcı Adı"></asp:TextBox>
                <asp:TextBox ID="txtGirisSifre" runat="server" TextMode="Password" Placeholder="Şifre"></asp:TextBox>
                <asp:Button ID="btnGiris" runat="server" Text="Giriş Yap" CssClass="aspNetButton" OnClick="btnGiris_Click" />
                <div class="switch-link" onclick="switchTo('kayitForm')">Hesabın yok mu? Kayıt ol</div>
            </div>

            <!-- KAYIT FORMU -->
            <div id="kayitForm" class="form-container">
                <h2>Kayıt Ol</h2>
                <asp:TextBox ID="txtKayitKullaniciAdi" runat="server" Placeholder="Kullanıcı Adı"></asp:TextBox>
                <asp:TextBox ID="txtKayitSifre" runat="server" TextMode="Password" Placeholder="Şifre"></asp:TextBox>
                <asp:TextBox ID="txtTc" runat="server" Placeholder="TC No"></asp:TextBox>
                <asp:TextBox ID="txtKayitEmail" runat="server" Placeholder="E-mail"></asp:TextBox>
                <asp:Button ID="btnKayit" runat="server" Text="Kayıt Ol" CssClass="aspNetButton" OnClick="btnKayit_Click" />
                <div class="switch-link" onclick="switchTo('girisForm')">Zaten hesabın var mı? Giriş yap</div>
            </div>
            
        </div>
    </form>

    <script>
        // İlk fade animasyonu
        gsap.to("#formBox", { duration: 1, opacity: 1, y: -20, ease: "power2.out" });

        function switchTo(formId) {
            // Formları gizle
            document.querySelectorAll(".form-container").forEach(form => {
                form.classList.remove("active");
            });

            // Seçilen formu göster
            document.getElementById(formId).classList.add("active");

            // GSAP geçiş animasyonu
            gsap.from("#" + formId, { opacity: 0, y: 20, duration: 0.5, ease: "power2.out" });
        }
    </script>
</body>
</html>