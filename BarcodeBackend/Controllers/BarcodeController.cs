namespace BarcodeBackend.Controllers
{
    public class BarcodeController
    {
         {
        private static int _nextId = 1;
        private static readonly List<Barcode> _duathletes = new List<Barcode>() {
            new Barcode(_nextId++, "Sophus", 3, 2000, 3000),
            new Barcode(_nextId++, "Jakob", 3, 2230, 2410),
            new Barcode(_nextId++, "Frank", 2, 2410, 3000),
            new Barcode(_nextId++, "Hans", 4, 3031, 2000),
            new Barcode(_nextId++, "Jens", 1, 5000, 3031)
            };

        public List<Barcode> duathletes
        {

            get
            {
                return _duathletes;
            }
        }
        public List<Barcode> getAll()
        {
            return _duathletes;
        }
        public Barcode getByBib(int bib)
        {
            var result = duathletes.FirstOrDefault(athlete => athlete.bib == bib);
            return result;
        }
        public void add(Barcode athlete)
        {
            athlete.validation();
            duathletes.Add(athlete);
        }
        public void delete(int bib)
        {

            var result = duathletes.FirstOrDefault(athlete => athlete.bib == bib);
            if (result != null)
            {
                duathletes.Remove(result);
            }
        }
    }
}

