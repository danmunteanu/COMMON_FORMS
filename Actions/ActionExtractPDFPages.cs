﻿using iText.Kernel.Pdf;

namespace CommonForms
{
    public class ActionExtractPDFPages : RealityFrameworks.Actions.Action<string>
    {
        public static int CountPages(string sourcePDF)
        {
            PdfDocument sourcePdf = new PdfDocument(new PdfReader(sourcePDF));
            return sourcePdf.GetNumberOfPages();
        }

        //  The Output PDF
        public string? Destination { get; set; } = null;

        //  List of pages to extract
        public List<int> Pages { get; set; } = new ();

        public static void ExtractPages(string sourcePdfPath, string destinationPdfPath, List<int> pagesToExtract)
        {
            // Open the source PDF
            using (PdfDocument sourcePdf = new PdfDocument(new PdfReader(sourcePdfPath)))
            {
                // Create a new PDF document for the extracted pages
                using (PdfDocument destinationPdf = new PdfDocument(new PdfWriter(destinationPdfPath)))
                {
                    // Loop through pages to extract and add to destination PDF
                    foreach (int pageNumber in pagesToExtract)
                    {
                        // Ensure the page number is valid
                        if (pageNumber > 0 && pageNumber <= sourcePdf.GetNumberOfPages())
                        {
                            // Copy the specific page from source to destination
                            sourcePdf.CopyPagesTo(pageNumber, pageNumber, destinationPdf);
                        }
                    }
                }
            }
        }

        public static bool IsValidPdf(string sourcePdf)
        {
            // Check if the file exists
            if (!File.Exists(sourcePdf))
            {
                //Console.WriteLine("Error: The file does not exist.");
                return false;
            }

            // Check if the file has a .pdf extension
            if (Path.GetExtension(sourcePdf).ToLower() != ".pdf")
            {
                //Console.WriteLine("Error: The file is not a PDF (must have a .pdf extension).");
                return false;
            }

            // Check if the file is a valid PDF
            try
            {
                using (PdfDocument pdfDoc = new PdfDocument(new PdfReader(sourcePdf)))
                {
                    // If it opens without exception, it's a valid PDF
                    if (pdfDoc.GetNumberOfPages() > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: The file is not a valid PDF. Details: {ex.Message}");
            }

            // If any checks fail, return false
            return false;
        }

        public override void Execute(string sourcePDF)
        {
            //  Ensure sourcePDF is a PDF file
            if (!IsValidPdf(sourcePDF))
            {
                throw new Exception("Not a valid PDF - Extract the Exception for more info");
            }

            if (
                //  Have a Destination File
                Destination != null && Destination != string.Empty &&

                //  At least one page
                Pages != null && Pages.Count > 0)
            {
                ExtractPages(sourcePDF, Destination, Pages);
            }
        }

        protected override void UpdateDescription()
        {
            mDescription = GetType().Name;
        }
    }

}
