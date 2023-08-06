using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Operators;
using PdfSharp.Drawing;


//// Inicializar objeto de documento
//Document document = new Document();

//// Adicionar Página
//Page page = document.Pages.Add();

//// Adicionar texto à nova página
//page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Hello World!"));

//// Salvar PDF 
//document.Save("document.pdf");

//// Abrir documento
//Document pdfDocument = new Document("document.pdf");

//// Definir coordenadas
//int lowerLeftX = 100;
//int lowerLeftY = 100;
//int upperRightX = 200;
//int upperRightY = 200;

//// Obtenha a página onde a imagem precisa ser adicionada
//Page page = pdfDocument.Pages[1];

//// Carregar imagem no fluxo
//FileStream imagemTopo = new FileStream("barra-laranja.jpg", FileMode.Open);
////FileStream imagemRodape = new FileStream("barra-fundo.jpg", FileMode.Open);

//// Adicionar imagem à coleção de imagens de recursos de página
//page.Resources.Images.Add(imagemTopo);
////page.Resources.Images.Add(imagemRodape);

//// Usando o operador GSave: este operador salva o estado gráfico atual
//page.Contents.Add(new Aspose.Pdf.Operators.GSave());

//// Criar objetos Retângulo e Matriz
//Aspose.Pdf.Rectangle rectangle = new Aspose.Pdf.Rectangle(lowerLeftX, lowerLeftY, upperRightX, upperRightY);
//Matrix matrix = new Matrix(new double[] { rectangle.URX - rectangle.LLX, 0, 0, rectangle.URY - rectangle.LLY, rectangle.LLX, rectangle.LLY });

//// Usando o operador ConcatenateMatrix (concatenate matrix): define como a imagem deve ser colocada
//page.Contents.Add(new Aspose.Pdf.Operators.ConcatenateMatrix(matrix));
//XImage ximage = page.Resources.Images[page.Resources.Images.Count];

//// Usando o operador Do: este operador desenha a imagem
//page.Contents.Add(new Aspose.Pdf.Operators.Do(ximage.Name));

//// Usando o operador GRestore: este operador restaura o estado gráfico
//page.Contents.Add(new Aspose.Pdf.Operators.GRestore());

//// Salvar documento atualizado
//pdfDocument.Save("document.pdf");
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
var document = new PdfSharp.Pdf.PdfDocument();
var page = document.AddPage();
var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
var font = new PdfSharp.Drawing.XFont("Calibri", 14);
var fontN = new PdfSharp.Drawing.XFont("Calibri", 14, XFontStyle.Bold);

// Imagem.
graphics.DrawImage(PdfSharp.Drawing.XImage.FromFile("img-topo.jpg"), 0, 20, 709, 84);

// Textos.
textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
textFormatter.DrawString("UC: {uc}.", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 110, page.Width - 60, page.Height - 60));
textFormatter.DrawString("Nome: {cliente}.", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 130, page.Width - 60, page.Height - 60));
textFormatter.DrawString("Endereço: {endereco}.", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 150, page.Width - 60, page.Height - 60));
textFormatter.DrawString("Municipio: {municipio}.", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 170, page.Width - 60, page.Height - 60));
textFormatter.DrawString("Prezado(a) Cliente, ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 190, page.Width - 60, page.Height - 60));
textFormatter.DrawString("{introducao}, ", fontN, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 210, page.Width - 60, page.Height - 60));

textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
textFormatter.DrawString("Mês/Ano: 1/2023 - Venc. 16/01/2023 - Valor R$ 94,68", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 230, page.Width - 60, page.Height - 60));
textFormatter.DrawString("{codigoBarras}", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 250, page.Width - 60, page.Height - 60));
textFormatter.DrawString("00190.00009 03268.926007 62738.624170 5 92320000009468", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 270, page.Width - 60, page.Height - 60));
textFormatter.DrawString("Se preferir, você pode pagar sua fatura pelo QR Code PIX abaixo:", fontN, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 290, page.Width - 60, page.Height - 60));
textFormatter.DrawString("{codigoPix}", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 310, page.Width - 60, page.Height - 60));

textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
textFormatter.DrawString("Se a(s) fatura(s) já foram paga(s), pedimos desculpas, e pode desconsiderar esse reaviso.", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 330, page.Width - 60, page.Height - 60));
textFormatter.DrawString("Mas, se a(s) fatura(s) ainda não foram paga(s), é importante que providencie a regularização", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 350, page.Width - 60, page.Height - 60));
textFormatter.DrawString("do débito e evite desconfortos, como a inclusão dos dados nos sistemas de proteção de ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 370, page.Width - 60, page.Height - 60));
textFormatter.DrawString("crédito, protesto e outras ações de cobrança. ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 390, page.Width - 60, page.Height - 60));
textFormatter.DrawString("Adicionalmente, a suspensão do fornecimento de energia pode ocorrer a partir de {resolucao}. ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 410, page.Width - 60, page.Height - 60));
textFormatter.DrawString("{pagamento},", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 450, page.Width - 60, page.Height - 60));
textFormatter.DrawString("Além disso, para sua segurança e tranquilidade, também guarde o comprovante de ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 490, page.Width - 60, page.Height - 60));
textFormatter.DrawString("pagamento para apresentar, se necessário, aos nossos colaboradores durante uma visita em ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 510, page.Width - 60, page.Height - 60));
textFormatter.DrawString("sua unidade. ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 530, page.Width - 60, page.Height - 60));
textFormatter.DrawString("Salientamos que esta notificação não exclui outras que porventura tenham sido enviadas. ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 550, page.Width - 60, page.Height - 60));
textFormatter.DrawString("{assinatura} ", fontN, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 570, page.Width - 60, page.Height - 60));
textFormatter.DrawString("{rodape} ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 590, page.Width - 60, page.Height - 60));

//textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Justify;
//textFormatter.DrawString("E, finalmente, aqui temos um parágrafo justificado. Aqui precisamos de mais texto para ver se o texto está realmente sendo justificado! Confira as outras categorias do meu site para artigos relacionados a outras tecnologias de desenvolvimento de software!",
//    font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 120, page.Width - 60, page.Height - 60));

//// Figuras geométricas.
//graphics.DrawRectangle(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.White, new PdfSharp.Drawing.XRect(100, 210, 180, 110));
//graphics.DrawEllipse(PdfSharp.Drawing.XPens.Black, PdfSharp.Drawing.XBrushes.White, new PdfSharp.Drawing.XRect(350, 210, 100, 100));

// Imagem.
graphics.DrawImage(PdfSharp.Drawing.XImage.FromFile("img-rodape.jpg"), 0, 610, 707, 79);

document.Save("output.pdf");
//System.Diagnostics.Process.Start("output.pdf");
Console.WriteLine("Arquivo PDF gerado!");

// The path to your PDF File.
string pdfFilePath = "output.pdf";

// Open document
using (Document documentN = new Document(pdfFilePath))
{
    // Encrypt PDF
    documentN.Encrypt("1234", "admin", DocumentPrivilege.AllowAll, CryptoAlgorithm.RC4x128, true);

    // Save updated PDF
    documentN.Save(pdfFilePath);
}

Console.ReadLine();