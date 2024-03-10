import pygame
import sys

# Khai báo biến và hằng số
WIDTH, HEIGHT = 600, 600
ROWS, COLS = 15, 15
SQUARE_SIZE = WIDTH // COLS
WHITE, BLACK = (255, 255, 255), (0, 0, 0)
X_COLOR, O_COLOR = (255, 0, 0), (0, 0, 255)  # Đỏ cho 'X', Xanh cho 'O'

# Khởi tạo bảng Caro
board = [[' ' for _ in range(COLS)] for _ in range(ROWS)]

# Khởi tạo Pygame
pygame.init()
screen = pygame.display.set_mode((WIDTH, HEIGHT))
pygame.display.set_caption('Caro Game')

def draw_board():
    for row in range(ROWS):
        for col in range(COLS):
            pygame.draw.rect(screen, WHITE, (col * SQUARE_SIZE, row * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE))
            pygame.draw.rect(screen, BLACK, (col * SQUARE_SIZE, row * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE), 1)
            if board[row][col] == 'X':
                pygame.draw.line(screen, X_COLOR, (col * SQUARE_SIZE + 10, row * SQUARE_SIZE + 10), (col * SQUARE_SIZE + SQUARE_SIZE - 10, row * SQUARE_SIZE + SQUARE_SIZE - 10), 4)
                pygame.draw.line(screen, X_COLOR, (col * SQUARE_SIZE + SQUARE_SIZE - 10, row * SQUARE_SIZE + 10), (col * SQUARE_SIZE + 10, row * SQUARE_SIZE + SQUARE_SIZE - 10), 4)
            elif board[row][col] == 'O':
                pygame.draw.circle(screen, O_COLOR, (col * SQUARE_SIZE + SQUARE_SIZE // 2, row * SQUARE_SIZE + SQUARE_SIZE // 2), SQUARE_SIZE // 2 - 10, 4)

def check_winner():
    # Kiểm tra hàng và cột
    for i in range(ROWS):
        for j in range(COLS - 4):
            if board[i][j] == board[i][j + 1] == board[i][j + 2] == board[i][j + 3] == board[i][j + 4] and board[i][j] != ' ':
                return True
            if board[j][i] == board[j + 1][i] == board[j + 2][i] == board[j + 3][i] == board[j + 4][i] and board[j][i] != ' ':
                return True

    # Kiểm tra đường chéo chính
    for i in range(ROWS - 4):
        for j in range(COLS - 4):
            if board[i][j] == board[i + 1][j + 1] == board[i + 2][j + 2] == board[i + 3][j + 3] == board[i + 4][j + 4] and board[i][j] != ' ':
                return True

    # Kiểm tra đường chéo phụ
    for i in range(4, ROWS):
        for j in range(COLS - 4):
            if board[i][j] == board[i - 1][j + 1] == board[i - 2][j + 2] == board[i - 3][j + 3] == board[i - 4][j + 4] and board[i][j] != ' ':
                return True

    return False

def restart_game():
    global board, game_over, turn
    board = [[' ' for _ in range(COLS)] for _ in range(ROWS)]
    game_over = False
    turn = 'X'

def show_winner_popup(winner):
    popup_font = pygame.font.Font(None, 48)
    popup_text = popup_font.render(f'Player {winner} wins!', True, WHITE)
    
    popup_rect = popup_text.get_rect(center=(WIDTH // 2, HEIGHT // 2))
    
    pygame.draw.rect(screen, BLACK, (popup_rect.x - 10, popup_rect.y - 10, popup_rect.width + 20, popup_rect.height + 20))
    screen.blit(popup_text, popup_rect)

    pygame.display.flip()
    pygame.time.delay(2000)  # Hiển thị thông báo trong 2 giây

# Vòng lặp chính
turn = 'X'
game_over = False

while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()
        elif event.type == pygame.MOUSEBUTTONDOWN and not game_over:
            mouseX, mouseY = event.pos
            clicked_row = mouseY // SQUARE_SIZE
            clicked_col = mouseX // SQUARE_SIZE

            if board[clicked_row][clicked_col] == ' ':
                board[clicked_row][clicked_col] = turn
                if check_winner():
                    print(f'Player {turn} wins!')
                    show_winner_popup(turn)
                    game_over = True
                turn = 'O' if turn == 'X' else 'X'
                
        # Xử lý nút chơi lại từ đầu
        elif event.type == pygame.MOUSEBUTTONDOWN and game_over:
            if WIDTH // 2 - 75 <= mouseX <= WIDTH // 2 + 75 and HEIGHT // 2 + 50 <= mouseY <= HEIGHT // 2 + 100:
                restart_game()

    screen.fill(WHITE)
    draw_board()

    if game_over:
        # Thêm nút chơi lại từ đầu
        pygame.draw.rect(screen, BLACK, (WIDTH // 2 - 75, HEIGHT // 2 + 50, 150, 50))
        restart_font = pygame.font.Font(None, 36)
        restart_text = restart_font.render('Play Again', True, WHITE)
        restart_rect = restart_text.get_rect(center=(WIDTH // 2, HEIGHT // 2 + 75))
        screen.blit(restart_text, restart_rect)

    pygame.display.flip()
