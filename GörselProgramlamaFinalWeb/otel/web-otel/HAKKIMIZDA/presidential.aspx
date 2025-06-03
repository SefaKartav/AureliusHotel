<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="presidential.aspx.cs" Inherits="otel.web_otel.HAKKIMIZDA.presidential" %>

<!DOCTYPE html>
<html lang="tr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Presidential Suite</title>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;600;700&display=swap" rel="stylesheet">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.12.5/gsap.min.js"></script>
    <style>
        body {
            font-family: 'Poppins', sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f5f5f5;
        }

        .navbar {
            background-color: #fff;
            padding: 15px 20px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            border-bottom: 1px solid #ddd;
        }

            .navbar a {
                color: #333;
                text-decoration: none;
                font-size: 16px;
                margin-right: 20px;
                transition: color 0.3s;
            }

                .navbar a:hover {
                    color: #ebef0c;
                }

                .navbar a.reservation {
                    background-color: #ebef0c;
                    color: #fff;
                    padding: 10px 20px;
                    border-radius: 5px;
                    transition: background-color 0.3s;
                }

                    .navbar a.reservation:hover {
                        background-color: #d6d80c;
                    }

        .container {
            display: flex;
            margin: 40px;
        }

        .sidebar {
            width: 20%;
            background-color: #fff;
            padding: 30px;
            border: 1px solid #ddd;
            border-radius: 8px;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
        }

            .sidebar h2 {
                font-size: 20px;
                margin-bottom: 20px;
                color: #333;
            }

            .sidebar ul {
                list-style: none;
                padding: 0;
            }

                .sidebar ul li {
                    margin-bottom: 12px;
                }

                    .sidebar ul li a {
                        text-decoration: none;
                        color: #666;
                        font-size: 16px;
                        transition: color 0.3s;
                    }

                        .sidebar ul li a:hover {
                            color: #ebef0c;
                        }

        .content {
            width: 80%;
            padding: 0 40px;
        }

        .slider {
            position: relative;
            width: 100%;
            height: 500px;
            background-color: #ddd;
            display: flex;
            align-items: center;
            justify-content: center;
            overflow: hidden;
            border-radius: 8px;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
        }

            .slider img {
                width: 100%;
                height: 100%;
                object-fit: cover;
                display: none;
                animation: fadeIn 0.5s ease-in-out;
            }

                .slider img.active {
                    display: block;
                }

        @keyframes fadeIn {
            0% {
                opacity: 0;
            }

            100% {
                opacity: 1;
            }
        }

        .slider .arrow {
            position: absolute;
            top: 50%;
            transform: translateY(-50%);
            font-size: 30px;
            color: #fff;
            cursor: pointer;
            background-color: rgba(0, 0, 0, 0.5);
            padding: 10px;
            border-radius: 50%;
            transition: background-color 0.3s;
        }

            .slider .arrow:hover {
                background-color: rgba(0, 0, 0, 0.7);
            }

        .slider .left-arrow {
            left: 20px;
        }

        .slider .right-arrow {
            right: 20px;
        }

        .room-details {
            background-color: #fff;
            padding: 30px;
            margin-top: 40px;
            border-radius: 8px;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
        }

            .room-details h3 {
                color: #ebef0c;
                margin-bottom: 20px;
                font-size: 24px;
            }

            .room-details .columns {
                display: flex;
                justify-content: space-between;
            }

                .room-details .columns div {
                    width: 30%;
                }

                .room-details .columns h4 {
                    font-size: 18px;
                    margin-bottom: 12px;
                    color: #333;
                }

                .room-details .columns ul {
                    list-style: none;
                    padding: 0;
                }

                    .room-details .columns ul li {
                        margin-bottom: 8px;
                        color: #666;
                        font-size: 15px;
                    }

        .reviews {
            background-color: #fff;
            padding: 30px;
            margin-top: 40px;
            border-radius: 8px;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
        }

            .reviews h3 {
                color: #ebef0c;
                margin-bottom: 20px;
                font-size: 24px;
            }

        .review-card {
            background-color: #f5f5f5;
            padding: 20px;
            border-radius: 8px;
            margin-bottom: 20px;
        }

            .review-card .reviewer {
                font-weight: 600;
                margin-bottom: 10px;
            }

            .review-card .rating {
                color: #ebef0c;
                margin-bottom: 10px;
            }

            .review-card .comment {
                color: #666;
            }

        .contact-btn {
            position: fixed;
            bottom: 20px;
            right: 20px;
            background-color: #ebef0c;
            color: #fff;
            padding: 12px 24px;
            border-radius: 25px;
            text-decoration: none;
            font-size: 16px;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
            transition: background-color 0.3s;
        }
              .comment-form {
        margin-top: 30px;
        background: #fff;
        padding: 20px;
        border-radius: 8px;
        box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
        text-align: left;
      }
      .comment-form textarea {
        width: 100%;
        height: 100px;
        padding: 10px;
        margin-bottom: 10px;
        border: 1px solid #ccc;
        border-radius: 5px;
        font-family: "Poppins", sans-serif;
      }
            .contact-btn:hover {
                background-color: #d6d80c;
            }
    </style>
</head>
<body>
        <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <div class="navbar">
        <a href="#">KONAKLAMA</a>
        <a href="restoran.html">RESTORAN & BARLAR</a>
        <a href="fitness.html">SPA & FITNESS</a>
        <a href="iletişim.html">İLETİŞİM</a>
        <a href="/web-otel/otel.aspx" class="reservation">ANASAYFA</a>
    </div>
    
    <div class="container">
        <div class="sidebar">
            <h2>KONAKLAMA</h2>
            <ul>
                <li><a href="anasayfa.aspx">STANDART ODA</a></li>
                <li><a href="deluxe.aspx">DELUXE ODA</a></li>
                <li><a href="executive.aspx">EXECUTIVE CLUB ODA</a></li>
                <li><a href="presidential.aspx">PRESİDENTİAL SUİTE</a></li>
                <li><a href="superior.aspx">SUPERİOR ODA</a></li>
            </ul>
        </div>

        <div class="content">
            <div class="slider">
                <img src="img2/presen.jpg" class="active" alt="Oda Resmi 1">
                <img src="img2/presen2.jpg" alt="Oda Resmi 2">
                <img src="img2/presen3.jpg" alt="Oda Resmi 3">
                <div class="arrow left-arrow">❮</div>
                <div class="arrow right-arrow">❯</div>
            </div>

            <div class="room-details">
                <h3>PRESİDENTİAL SUİTE</h3>
                <div class="columns">
                    <div>
                        <h4>ODA ÖZELLİKLERİ</h4>
                        <ul>
                            <li>Göl & Deniz veya Şehir Manzaralı</li>
                            <li>4 Yatak Odası (250m2)</li>
                            <li>Genel Alanda Mutfak (Tezgah + Buzdolabı)</li>
                            <li>Genel Alanda WC</li>
                            <li>Direkt Hatlı Telefon</li>
                            <li>Kasa</li>
                            <li>MINI BAR</li>
                            <li>Çay Kahve Setup</li>
                            <li>Merkezi Isıtma & Soğutma</li>
                            <li>8 Kişilik Çalışma Masası</li>
                        </ul>
                    </div>
                    <div>
                        <h4>BANYO</h4>
                        <ul>
                            <li>1 Banyo</li>
                            <li>Küvet veya Ayır Duş</li>
                            <li>Banyoda Telefon</li>
                            <li>Saç Kurutma Makinesi</li>
                            <li>Merkezi Klima</li>
                        </ul>
                    </div>
                    <div>
                        <h4>TEKNOLOJİ</h4>
                        <ul>
                            <li>2 LED TV + CD Çalar</li>
                            <li>Sınırsız Ücretsiz İnternet Bağlantısı</li>
                        </ul>
                    </div>
                </div>
            </div>

            <div class="reviews">
                <h3>Müşteri Yorumları</h3>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:Repeater ID="rptYorumlar" runat="server">
            <ItemTemplate>
                <div class="review-card">
                    <div class="reviewer"><%# Eval("kullanici_adi") %></div>
                    <div class="rating">
                        <%# new String('★', Convert.ToInt32(Eval("puan"))) %>
                    </div>
                    <div class="comment"><%# Eval("yorum") %></div>
                    <div style="font-size:12px; color:#999;">
                        <%# Convert.ToDateTime(Eval("tarih")).ToString("dd.MM.yyyy HH:mm") %>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <div class="comment-form">
            <h4>Yorum Ekle</h4>
            <asp:TextBox ID="txtYorum" runat="server" TextMode="MultiLine" placeholder="Yorumunuzu yazın..." CssClass="form-control"></asp:TextBox>
            <br />
            <asp:DropDownList ID="ddlPuan" runat="server">
                <asp:ListItem Value="1">1 Yıldız</asp:ListItem>
                <asp:ListItem Value="2">2 Yıldız</asp:ListItem>
                <asp:ListItem Value="3">3 Yıldız</asp:ListItem>
                <asp:ListItem Value="4">4 Yıldız</asp:ListItem>
                <asp:ListItem Value="5">5 Yıldız</asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <asp:Button ID="btnYorumGonder" runat="server" Text="Yorumu Gönder" CssClass="btn" OnClick="btnYorumGonder_Click" ></asp:Button>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
            </div>
        </div>
    </div>

    <a href="/WebForm1.aspx" class="contact-btn">REZERVASYON YAP</a>
             </form>
    <script>
        // Slider script
        const images = document.querySelectorAll('.slider img');
        const leftArrow = document.querySelector('.left-arrow');
        const rightArrow = document.querySelector('.right-arrow');
        let currentIndex = 0;

        function showImage(index) {
            images.forEach((img, i) => {
                img.classList.toggle('active', i === index);
            });
        }

        leftArrow.addEventListener('click', () => {
            currentIndex = (currentIndex - 1 + images.length) % images.length;
            showImage(currentIndex);
        });

        rightArrow.addEventListener('click', () => {
            currentIndex = (currentIndex + 1) % images.length;
            showImage(currentIndex);
        });

        // GSAP Animations
        document.addEventListener('DOMContentLoaded', () => {
            // Animate navbar links
            gsap.from('.navbar a', {
                opacity: 0,
                y: -20,
                duration: 0.8,
                stagger: 0.1,
                ease: 'power2.out'
            });

            // Animate sidebar
            gsap.from('.sidebar', {
                opacity: 0,
                x: -50,
                duration: 1,
                ease: 'power2.out',
                delay: 0.2
            });

            // Animate slider
            gsap.from('.slider', {
                opacity: 0,
                scale: 0.9,
                duration: 1.2,
                ease: 'power2.out',
                delay: 0.4
            });

            // Animate room details columns
            gsap.from('.room-details .columns div', {
                opacity: 0,
                y: 30,
                duration: 1,
                stagger: 0.2,
                ease: 'power2.out',
                delay: 0.6
            });

            // Animate reviews
            gsap.from('.review-card', {
                opacity: 0,
                y: 30,
                duration: 0.8,
                stagger: 0.2,
                ease: 'power2.out',
                delay: 0.8
            });

            // Animate contact button
            gsap.from('.contact-btn', {
                opacity: 0,
                y: 50,
                duration: 0.8,
                ease: 'power2.out',
                delay: 0.8
            });
        });
    </script>
</body>
</html>