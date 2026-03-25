using AuditLogger.Core.Service;
using AuditLogger.Core.Stores;

namespace AuditLogger.WinForms
{
    public partial class Form1 : Form
    {
        private AuditService _auditService;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            if (rbMemory.Checked)
            {
                _auditService = new AuditService(new MemoryLogStore());
            }
            else if (rbFile.Checked)
            {
                _auditService = new AuditService((new FileLogStore("logs.txt")));
            }
            else if (rbDatabase.Checked)
            {
                MessageBox.Show("Данный функционал не написан.");
            }
            else if (rbDatabase.Checked)
            {
                _auditService = new AuditService(
                    new DbLogStore("Host=46.191.235.28;Port=5432;Username=postgres;Password=Asdf=1234Asdf=1234;Database=PM_01")
                );
            }
            MessageBox.Show("Сервис Инициализирован");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var allLogs = _auditService.GetLogs();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = allLogs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_auditService == null)
            {
                MessageBox.Show("Нужна инициализация");
                return;
            }
            _auditService.LogAction("user1", "CLICK_BUTTON", $"{ActiveForm.Name}");
            MessageBox.Show("Лог Добавлен");
        }
    }
}
