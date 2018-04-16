using System.Collections.Generic;

namespace Discord
{
    /// <summary>
    ///     Properties that are used to modify an <see cref="IGuildUser" /> with the following parameters.
    /// </summary>
    /// <example>
    ///     <code lang="c#">
    /// await (Context.User as IGuildUser)?.ModifyAsync(x =&gt;
    /// {
    ///     x.Nickname = $"festive {Context.User.Username}";
    /// });
    /// </code>
    /// </example>
    /// <seealso cref="T:Discord.IGuildUser" />
    public class GuildUserProperties
    {
        /// <summary>
        ///     Sets whether the user should be muted in a voice channel.
        /// </summary>
        /// <remarks>
        ///     If this value is set to <see langword="true"/>, no user will be able to hear this user speak in the guild.
        /// </remarks>
        public Optional<bool> Mute { get; set; }
        /// <summary>
        ///     Sets whether the user should be deafened in a voice channel.
        /// </summary>
        /// <remarks>
        ///     If this value is set to <see langword="true"/>, this user will not be able to hear anyone speak in the guild.
        /// </remarks>
        public Optional<bool> Deaf { get; set; }
        /// <summary>
        ///     Sets the user's nickname.
        /// </summary>
        /// <remarks>
        ///     To clear the user's nickname, this value can be set to <see langword="null" /> or
        ///     <see cref="string.Empty" /> .
        /// </remarks>
        public Optional<string> Nickname { get; set; }
        /// <summary>
        ///     Sets the roles the user should have.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To add a role to a user:
        ///         <see cref="IGuildUser.AddRolesAsync(IEnumerable{IRole},RequestOptions)" />
        ///     </para>
        ///     <para>
        ///         To remove a role from a user:
        ///         <see cref="IGuildUser.RemoveRolesAsync(IEnumerable{IRole},RequestOptions)" />
        ///     </para>
        /// </remarks>
        public Optional<IEnumerable<IRole>> Roles { get; set; }
        /// <summary>
        ///     Sets the roles the user should have.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To add a role to a user:
        ///         <see cref="IGuildUser.AddRolesAsync(IEnumerable{IRole},RequestOptions)" />
        ///     </para>
        ///     <para>
        ///         To remove a role from a user:
        ///         <see cref="IGuildUser.RemoveRolesAsync(IEnumerable{IRole},RequestOptions)" />
        ///     </para>
        /// </remarks>
        public Optional<IEnumerable<ulong>> RoleIds { get; set; }
        /// <summary>
        ///     Moves a user to a voice channel.
        /// </summary>
        /// <remarks>
        ///     This user MUST already be in a <see cref="IVoiceChannel"/> for this to work.
        /// </remarks>
        public Optional<IVoiceChannel> Channel { get; set; }
        /// <summary>
        ///     Moves a user to a voice channel.
        /// </summary>
        /// <remarks>
        ///     This user MUST already be in a <see cref="IVoiceChannel"/> for this to work.
        /// </remarks>
        public Optional<ulong> ChannelId { get; set; }
    }
}
