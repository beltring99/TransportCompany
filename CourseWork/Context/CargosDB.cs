﻿using CourseWork.Util;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseWork.Context
{
    public class CargosDB
    {
        public static void SelectAllInfo(DataGridView dataGridView1)
        {
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var cargos = db.Cargos.ToList();
                    foreach (var cargo in cargos)
                    {
                        dataGridView1.Rows.Add(new string[] {
                            Convert.ToString(cargo.Id),
                            cargo.Name,
                            Convert.ToString(cargo.Cost),
                            Convert.ToString(cargo.Weight),
                            Convert.ToString(cargo.Volume),
                            cargo.TrailerType,
                            cargo.UploadDate.ToString(),
                            cargo.Status,
                            cargo.DownloadLocation,
                            cargo.PlaceOfDischarge,
                            Convert.ToString(cargo.Distance)

                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Select(DataGridView dataGridView1)
        {
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var cargos = db.Cargos.ToList();
                    foreach (var cargo in cargos)
                    {
                        dataGridView1.Rows.Add(new string[] {
                            Convert.ToString(cargo.Id),
                            cargo.Name,
                            Convert.ToString(cargo.Cost),
                            Convert.ToString(cargo.Weight),
                            Convert.ToString(cargo.Volume),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Cargo SelectById(int id)
        {
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var cargos = db.Cargos.ToList();
                    foreach (var cargo in cargos)
                    {
                        if(cargo.Id == id)
                        {
                            return cargo;
                        }
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool EditCargo(int id, Cargo cargo)
        {
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    bool result = false;
                    DataValidation dataValidation = new DataValidation();
                    if (dataValidation.CheckAllInput(cargo))
                    {
                        var cargos = db.Cargos.ToList();
                        for (int i = 0; i < cargos.Count; i++)
                        {
                            if (cargos[i].Id == id)
                            {
                                cargos[i].CopyFields(cargo);
                                db.SaveChanges();
                                result = true;
                            }
                        }
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string SelectAllDetailed(int id)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var cargos = db.Cargos.ToList();
                    foreach (var cargo in cargos)
                    {
                        if(cargo.Id == id)
                        {
                            result.Append($"Название: {cargo.Name} \nСтоимость: {cargo.Cost} \nВес: {cargo.Weight} \nОбъём: {cargo.Volume} \n" +
                                $"Тип кузова: { cargo.TrailerType} \nДата загрузки: {cargo.UploadDate} \nСтатус заказа: {cargo.Status} \nМесто загрузки: " +
                                $"{cargo.DownloadLocation} \nМесто разгрузки: {cargo.PlaceOfDischarge} \nРасстояние: {cargo.Distance}\n");    
                        }
                    }
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result.ToString();
        }

        public static void UpdateStatus(string status, int id)
        {
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var cargos = db.Cargos.ToList();
                    foreach (var cargo in cargos)
                    {
                        if(cargo.Id == id)
                        {
                            cargo.Status = status;
                        }
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SelectFavourites(DataGridView dataGridView1, int[] id)
        {
            dataGridView1.Update();

            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var cargos = db.Cargos.ToList();
                    foreach (int element in id)
                    {
                        foreach (var cargo in cargos)
                        {
                            if (cargo.Id == element)
                            {
                                dataGridView1.Rows.Add(new string[] {
                                    Convert.ToString(cargo.Id),
                                    cargo.Name,
                                    Convert.ToString(cargo.Cost),
                                    Convert.ToString(cargo.Weight),
                                    Convert.ToString(cargo.Volume),
                                    cargo.TrailerType,
                                    cargo.UploadDate.ToString(),
                                    cargo.Status,
                                    cargo.DownloadLocation,
                                    cargo.PlaceOfDischarge,
                                    Convert.ToString(cargo.Distance)
                                });
                                break;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        public static bool AddCargo(Cargo cargo)
        {
            try
            {
                DataValidation dataValidation = new DataValidation();

                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    bool result;
                    if (dataValidation.CheckAllInput(cargo))
                    {
                        db.Cargos.Add(cargo);
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool DeleteCargo(int id)
        {
            try 
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    bool result = false;
                    if(id > 0)
                    {
                        var cargos = db.Cargos.ToList();
                        foreach (var cargo in cargos)
                        {
                            if (id > 0 && cargo.Id == id)
                            {
                                db.Cargos.Remove(cargo);
                                result = true;
                            }
                        }

                        db.SaveChanges();
                    }
                    else
                    {
                        result = false;
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CheckCargoInDB(Cargo newCargo)
        {
            try
            {
                using (TransportCompanyContext db = new TransportCompanyContext())
                {
                    var cargos = db.Cargos.ToList();
                    foreach (var cargo in cargos)
                    {
                        if (cargo.Equals(newCargo))
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
