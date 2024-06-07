# MsgTyper

Simple Messaging Application using Windows Forms

1. **Login Level Security:**
   * **Admin:** Full access to application features.
   * **User:** Access to basic features.
   * **Guest:** Limited access.

2. **Data Storage:**
   * The application saves information about sent messages, including:
     * Who sent it, to whom, when, and the message content.
   * Login data (login, password, optional hint) are stored in a JSON file and are always accessible to the admin.
   * The application saves the data of recent logins and all logins (both admins and users).

3. **Scalability:**
   * The application is designed with easy expansion in mind.
   * In the event of adding new features, the data structure and application logic are flexible.

