export function maskEmail(email: string): string {
  const [name, domain] = email.split("@");
  if (!name || !domain) return email;
  return name[0] + "***" + name[name.length] + "@" + domain;
}
