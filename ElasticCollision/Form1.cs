using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElasticCollision
{
    public partial class MainForm : Form
    {
        private Timer timer;
        private CollisionObject object1;
        private CollisionObject object2;
        private PhysicsProperties properties;

        private bool isStart;

        private const double BaseMass1 = 10;
        private const double BaseMass2 = 15;
        private const double BaseRadius1 = 20;
        private const double BaseRadius2 = 40;
        private const double BaseX1 = 25;
        private const double BaseX2 = 575;
        private const double BaseVelocity1 = 100;
        private const double BaseVelocity2 = -150;

        private double timeStep = 0.01;

        Dictionary<string, double> materialCoefficients = new Dictionary<string, double>
        {
            { "Резина", 0.99 },
            { "Пластик", 0.85 },
            { "Бильярный шар", 0.95 },
            { "Металл", 0.7 },
            { "Идеальный", 1 }
        };
        Dictionary<string, double> materialFrictionCoefficients = new Dictionary<string, double>
        {
            { "Дерево сухое", 0.6 },
            { "Сталь сухая", 0.5 },
            { "Лед", 0.1 },
            { "Масло на стали", 0.02 },
            { "Идеальный", 0 }
        };

        public MainForm()
        {
            InitializeComponent();
            InitializeTimer();
            InitializeObjects();
            InitializeProperties();
            InitializeComboBox();
            InitializeNumericUpDown();
        }
        private void SimulateCollision()
        {
            CollisionWBorders();

            if (object1.X + object1.Radius >= object2.X - object2.Radius)
            {
                double initialKineticEnergy1 = 0.5 * object1.Mass * Math.Pow(object1.Velocity, 2);
                double initialKineticEnergy2 = 0.5 * object2.Mass * Math.Pow(object2.Velocity, 2);

                // Рассчитываем новые скорости после столкновения с учетом упругости
                double v1f = ((object1.Mass - object2.Mass) * object1.Velocity +
                              2 * object2.Mass * object2.Velocity) / (object1.Mass + object2.Mass);
                double v2f = (2 * object1.Mass * object1.Velocity +
                              (object2.Mass - object1.Mass) * object2.Velocity) / (object1.Mass + object2.Mass);

                object1.Velocity = v1f * object1.RestitutionCoefficient;
                object2.Velocity = v2f * object2.RestitutionCoefficient;

                // Применяем силу трения после столкновения
                object1.Velocity -= properties.FrictionCoefficient / 10 * object1.Velocity;
                object2.Velocity -= properties.FrictionCoefficient / 10 * object2.Velocity;

                // Обновляем позиции шаров
                object1.X += object1.Velocity * timeStep;
                object2.X += object2.Velocity * timeStep;

                // Вычисляем конечную кинетическую энергию после столкновения
                double finalKineticEnergy1 = 0.5 * object1.Mass * Math.Pow(object1.Velocity, 2);
                double finalKineticEnergy2 = 0.5 * object2.Mass * Math.Pow(object2.Velocity, 2);

                // Вычисляем изменение в кинетической энергии
                double kineticEnergyChange1 = finalKineticEnergy1 - initialKineticEnergy1;
                double kineticEnergyChange2 = finalKineticEnergy2 - initialKineticEnergy2;

                // Можно использовать изменение в кинетической энергии для анализа
            }

            else
            {
                // Применяем силу трения перед столкновением
                object1.Velocity -= properties.FrictionCoefficient * object1.Velocity * timeStep;
                object2.Velocity -= properties.FrictionCoefficient * object2.Velocity * timeStep;

                // Обновляем позиции шаров, если они еще не столкнулись
                object1.X += object1.Velocity * timeStep;
                object2.X += object2.Velocity * timeStep;
            }
        }
        private void CollisionWBorders()
        {
            // Обработка столкновения с левой стенкой
            if (object1.X - object1.Radius < 0)
            {
                object1.Velocity = Math.Abs(object1.Velocity) * properties.WallRestitution;
            }
            if (object2.X - object2.Radius < 0)
            {
                object2.Velocity = Math.Abs(object2.Velocity) * properties.WallRestitution;
            }

            // Обработка столкновения с правой стенкой
            if (object1.X + object1.Radius > pictureBox1.ClientRectangle.Width)
            {
                object1.Velocity = -Math.Abs(object1.Velocity) * properties.WallRestitution;
            }
            if (object2.X + object2.Radius > pictureBox1.ClientRectangle.Width)
            {
                object2.Velocity = -Math.Abs(object2.Velocity) * properties.WallRestitution;
            }

            // Обновляем позиции шаров
            object1.X += object1.Velocity * timeStep;
            object2.X += object2.Velocity * timeStep;
        }
        private void InitializeNumericUpDown()
        {
            velocityNumeric1.Increment = 0.1M;
            velocityNumeric2.Increment = 0.1M;

            massNumeric1.Increment = 0.1M;
            massNumeric1.Minimum = 0.1M;
            massNumeric2.Increment = 0.1M;
            massNumeric2.Minimum = 0.1M;

            radiusNumeric1.Increment = 0.1M;
            radiusNumeric1.Minimum = 0.1M;
            radiusNumeric2.Increment = 0.1M;
            radiusNumeric2.Minimum = 0.1M;

            SetNumericDefault();
        }
        private void InitializeComboBox()
        {
            materialComboBox1.Items.Add("Резина");
            materialComboBox1.Items.Add("Пластик");
            materialComboBox1.Items.Add("Бильярный шар");
            materialComboBox1.Items.Add("Металл");
            materialComboBox1.Items.Add("Идеальный");

            materialComboBox2.Items.Add("Резина");
            materialComboBox2.Items.Add("Пластик");
            materialComboBox2.Items.Add("Бильярный шар");
            materialComboBox2.Items.Add("Металл");
            materialComboBox2.Items.Add("Идеальный");

            materialComboBox3.Items.Add("Резина");
            materialComboBox3.Items.Add("Пластик");
            materialComboBox3.Items.Add("Бильярный шар");
            materialComboBox3.Items.Add("Металл");
            materialComboBox3.Items.Add("Идеальный");

            materialComboBox4.Items.Add("Дерево сухое");
            materialComboBox4.Items.Add("Сталь сухая");
            materialComboBox4.Items.Add("Лед");
            materialComboBox4.Items.Add("Масло на стали");
            materialComboBox4.Items.Add("Идеальный");

            materialComboBox1.SelectedIndex = 0;
            materialComboBox2.SelectedIndex = 0;
            materialComboBox3.SelectedIndex = 0;
            materialComboBox4.SelectedIndex = 4;
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }
        private void InitializeObjects()
        {
            SetDefaultObjects();
        }
        private void InitializeProperties()
        {
            SetDefaultProperties();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            SimulateCollision();
            UpdateLabelsData();
            pictureBox1.Invalidate(); // Обновляем изображение на PictureBox
        }
        private void UpdateLabelsData()
        {
            double velocity1 = Math.Abs(object1.Velocity);
            double velocity2 = Math.Abs(object2.Velocity);

            double kineticEnergy1 = 0.5 * object1.Mass * Math.Pow(velocity1, 2);
            double kineticEnergy2 = 0.5 * object2.Mass * Math.Pow(velocity2, 2);

            velocityLabel1.Text = $"Скорость шара : {velocity1:F2} м/с";
            velocityLabel2.Text = $"Скорость шара : {velocity2:F2} м/с";

            energyLabel1.Text = $"Кинетическая энергия шара : {kineticEnergy1 / 1000:F2} кДж";
            energyLabel2.Text = $"Кинетическая энергия шара : {kineticEnergy2 / 1000:F2} кДж";
        }
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawObjects(e.Graphics); // Рисуем объекты на PictureBox
        }
        private void DrawObjects(Graphics g)
        {
            g.Clear(Color.White);

            Brush brush1 = Brushes.Blue;
            Brush brush2 = Brushes.Red;

            int object1X = (int)object1.X;
            int object2X = (int)object2.X;

            g.FillEllipse(brush1, object1X - (int)object1.Radius, pictureBox1.ClientRectangle.Height / 2 - (int)object1.Radius, (int)object1.Radius * 2, (int)object1.Radius * 2);
            g.FillEllipse(brush2, object2X - (int)object2.Radius, pictureBox1.ClientRectangle.Height / 2 - (int)object2.Radius, (int)object2.Radius * 2, (int)object2.Radius * 2);

            g.DrawRectangle(Pens.Black, 0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);// Отрисовка окантовки по границам PictureBox
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            SetStopBtn();
            ResetToStart();
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!isStart)
            {
                SetStartBtn();
            }
            else
            {
                SetStopBtn();
            }
        }
        private void SetStartBtn()
        {
            object1.Velocity = object1.StartVelocity;
            object2.Velocity = object2.StartVelocity;
            startStopBtn.Text = "Стоп";
            isStart = true;
            timer.Start();
        }
        private void SetStopBtn()
        {
            startStopBtn.Text = "Старт";
            isStart = false;
            timer.Stop();
        }
        private void ResetToDefault()
        {
            object1.Radius = BaseRadius1;
            object2.Radius = BaseRadius2;
            object1.Mass = BaseMass1;
            object2.Mass = BaseMass2;

            materialComboBox1.SelectedIndex = 0;
            materialComboBox2.SelectedIndex = 0;
            materialComboBox3.SelectedIndex = 0;
            materialComboBox4.SelectedIndex = 4;

            SetNumericDefault();

            UpdateLabelsData();

            pictureBox1.Invalidate(); // Перерисовать PictureBox
        }
        private void SetDefaultObjects()
        {
            object1 = new CollisionObject()
            {
                Mass = BaseMass1,
                Radius = BaseRadius1,
                X = BaseX1,
                StartVelocity = BaseVelocity1,
            };
            object2 = new CollisionObject()
            {
                Mass = BaseMass2,
                Radius = BaseRadius2,
                X = BaseX2,
                StartVelocity = BaseVelocity2,
            };
        }
        private void SetDefaultProperties()
        {
            properties = new PhysicsProperties()
            {
                FrictionCoefficient = 0.001,
                WallRestitution = 0.99,
                SurfaceRestitution = 0.99
            };
        }
        private void SetNumericDefault()
        {
            velocityNumeric1.Value = Convert.ToDecimal(BaseVelocity1);
            velocityNumeric2.Value = Convert.ToDecimal(BaseVelocity2);

            massNumeric1.Value = Convert.ToDecimal(BaseMass1);
            massNumeric2.Value = Convert.ToDecimal(BaseMass2);

            radiusNumeric1.Value = Convert.ToDecimal(BaseRadius1);
            radiusNumeric2.Value = Convert.ToDecimal(BaseRadius2);
        }
        private void ResetToStart()
        {
            object1.X = BaseX1;
            object2.X = BaseX2;
            object1.Velocity = object1.StartVelocity;
            object2.Velocity = object2.StartVelocity;

            UpdateLabelsData();

            pictureBox1.Invalidate(); // Перерисовать PictureBox
        }
        private void materialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            string selectedMaterial = comboBox.SelectedItem.ToString();
            string text = "Коэфф упругости ";

            switch (comboBox.Tag)
            {
                case "0":
                    object1.RestitutionCoefficient = materialCoefficients[selectedMaterial];
                    restitutionCoefficientLabel1.Text = text + "шара: " + materialCoefficients[selectedMaterial].ToString();
                    break;
                case "1":
                    object2.RestitutionCoefficient = materialCoefficients[selectedMaterial];
                    restitutionCoefficientLabel2.Text = text + "шара: " + materialCoefficients[selectedMaterial].ToString();
                    break;
                case "2":
                    properties.WallRestitution = materialCoefficients[selectedMaterial];
                    restitutionCoefficientLabel3.Text = text + "стен: " + materialCoefficients[selectedMaterial].ToString();
                    break;
                case "3":
                    properties.FrictionCoefficient = materialFrictionCoefficients[selectedMaterial];
                    frictionCoefficientLabel1.Text = "Коэфф трения поверхности: " + materialFrictionCoefficients[selectedMaterial].ToString();
                    break;
            }
        }
        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;

            double value = (double)numeric.Value;

            switch(numeric.Tag)
            {
                case "0":
                    object1.StartVelocity = value;
                    break;
                case "1":
                    object2.StartVelocity = value;
                    break;
                case "2":
                    object1.Mass = value;
                    break;
                case "3":
                    object2.Mass = value;
                    break;
                case "4":
                    object1.Radius = value;
                    break;
                case "5":
                    object2.Radius = value;
                    break;
            }
        }
        private void setDefaultBtn_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }
    }
}