const getters = {
  sidebar: state => state.app.sidebar,
  device: state => state.app.device,
  token: state => state.user.token,
  avatar: state => state.user.avatar,
  name: state => state.user.name,
  code: state => state.user.code,
  phoneNumber: state => state.user.phoneNumber,
  roles: state => state.user.roles,
  isInitAdminMenu: state => state.user.isInitAdminMenu,
  permission_routes: state => state.permission.routes,
  cachedViews: state => state.tagsView.cachedViews,
  visitedViews: state => state.tagsView.visitedViews
}
export default getters
