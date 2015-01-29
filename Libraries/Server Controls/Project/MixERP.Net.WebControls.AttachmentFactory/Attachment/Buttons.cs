﻿using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.AttachmentFactory
{
    public sealed partial class Attachment
    {
        private void CreateButtons(Control container)
        {
            using (HtmlGenericControl buttonContainer = new HtmlGenericControl("div"))
            {
                buttonContainer.Attributes.Add("class", "vpad8");
                this.CreateUploadButton(buttonContainer);
                this.CreateUndoButton(buttonContainer);

                container.Controls.Add(buttonContainer);
                this.CreatSaveButton(buttonContainer);
            }
        }

        private void CreateUndoButton(HtmlGenericControl container)
        {
            using (HtmlInputButton undoButton = new HtmlInputButton())
            {
                undoButton.ID = "UndoButton";
                undoButton.Value = "Undo";
                undoButton.Attributes.Add("class", "ui small red button");

                container.Controls.Add(undoButton);
            }
        }

        private void CreateUploadButton(HtmlGenericControl container)
        {
            using (HtmlInputButton uploadButton = new HtmlInputButton())
            {
                uploadButton.ID = "UploadButton";
                uploadButton.Value = "Upload";
                uploadButton.Attributes.Add("class", "ui small blue button");

                container.Controls.Add(uploadButton);
            }
        }

        private void CreatSaveButton(HtmlGenericControl container)
        {
            using (HtmlInputButton saveButton = new HtmlInputButton())
            {
                saveButton.ID = "SaveButton";
                saveButton.Attributes.Add("class", "ui small green button");
                saveButton.Value = "Save";
                saveButton.Visible = this.ShowSaveButton;

                container.Controls.Add(saveButton);
            }
        }
    }
}