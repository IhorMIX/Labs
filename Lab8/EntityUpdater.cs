public abstract class EntityUpdater
{
    //update logic
    public void UpdateEntity()
    {
        var entity = GetEntity();
        if (ValidateEntity(entity))
        {
            SaveEntity(entity);
            OnSuccess();
        }
        else
        {
            OnValidationFailed();
        }
    }
    // base methods
    protected abstract object GetEntity();
    protected abstract bool ValidateEntity(object entity);
    protected abstract void SaveEntity(object entity);

    // hooks
    protected virtual void OnSuccess() { }
    protected virtual void OnValidationFailed() { }
}