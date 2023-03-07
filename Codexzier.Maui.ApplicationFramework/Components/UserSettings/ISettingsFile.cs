namespace Codexzier.Maui.ApplicationFramework.Components.UserSettings
{
    /// <summary>
    /// Defines the basic length, which functions are needed to edit the settings, so that it can be recognized whether the content should be saved or not.
    /// </summary>
    public interface ISettingsFile
    {
        /// <summary>
        /// Return true, if any value of the settings has changed.
        /// </summary>
        /// <returns></returns>
        bool HasChanged();
        /// <summary>
        /// Sets the status that one of the values has changed.
        /// </summary>
        void SetChanged();
        /// <summary>
        /// Reset the status that nothing has changed. Sometimes processes can come that actually do not involve any changes.
        /// </summary>
        void NoChanged();
    }
}